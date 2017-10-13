param(
	[String]$PackageLocation=(Split-Path $script:MyInvocation.MyCommand.Path),
	[String]$NUnitCategory="Regression",
	[String]$ReportLocation="C:\Temp\ReportsDistribution"
)

$OutDir=Join-Path -Path "$PackageLocation" -ChildPath "Reports"

Write-Host "PackageLocation: $PackageLocation"
Write-Host "OutDir: $OutDir"

$reportUnitExe = "$PackageLocation\Tools\ReportUnit\ReportUnit.exe"
$NUnitExecutablePath = "$PackageLocation\Tools\NUnit3_Console\nunit3-console.exe"
$NUnitTestAssemblies = "$PackageLocation\CI.ClinicalTrials.RegressionTest.dll"

$date = Get-Date -UFormat %Y-%m-%d-%H-%M-%S
$millisecondDate = Get-Date -UFormat %s
[int]$unique = "{0:N0}" -f $millisecondDate

$ResultFileName = "$OutDir\$date\TestResult-$unique.xml"
$ResultDir = "$OutDir\$date"

New-Item $ResultDir -type directory

New-Item $ResultFileName -type File

Write-Output "...Verifying the Set Parameters..."

Write-Output $NUnitExecutablePath
Write-Output $NUnitTestAssemblies
Write-Output $ResultFileName

Write-Output "...We are running NUnit tests..."

$Category = @"
cat==$NUnitCategory
"@

$runNUnit = "& $NUnitExecutablePath $NUnitTestAssemblies --work=$ResultDir --labels=All --output=$ResultFileName --where $Category"

Invoke-Expression $runNUnit

$nunitExit = $lastExitCode

IF ($nunitExit -eq 0)
{
 "Test suite is succesfully executed"	
}

Write-Host "Parsing Test Results from the XML File"

[ xml ]$fileContents = Get-Content -Path "$ResultDir\TestResult.xml"

Write-Host "Copied the Contents from XML ...."

$xml_totaltests = $fileContents.SelectSingleNode("/test-run[@id='2']").GetAttribute("total")
$xml_testspassed = $fileContents.SelectSingleNode("/test-run[@id='2']").GetAttribute("passed")
$xml_testsfailed = $fileContents.SelectSingleNode("/test-run[@id='2']").GetAttribute("failed")

$xml_testresult = $fileContents.SelectSingleNode("/test-run[@id='2']").GetAttribute("result")


Write-Host "Total Number of Tests : " $xml_totaltests
Write-Host "Number of Tests Passed : " $xml_testspassed
Write-Host "Number of Tests Failed : " $xml_testsfailed

Write-Host "TEST EXECUTION RESULT : " $xml_testresult

Write-Host "...Copying Test Results to Octopus Variables..."


Write-Host "Running ReportUnit.exe..."

Push-Location "$ResultDir"

$runReportUnit = "& $reportUnitExe TestResult.xml TestResult.html"

Write-Host "Let's execute the ReportUnit XML beautifier..."
 
Invoke-Expression $runReportUnit

$localReportPath = Join-Path -Path $packageLocation -ChildPath "Reports"
$reportFile = "$date\TestResult.html"

$localReportPath = Join-Path -Path $localReportPath -ChildPath $reportFile

$inOctopusContext = [bool](Get-Command "Set-OctopusVariable" -errorAction SilentlyContinue)
if ($inOctopusContext)
{
	Set-OctopusVariable -name "TotalTests" -value $xml_totaltests
	Set-OctopusVariable -name "TotalPassed" -value $xml_testspassed
	Set-OctopusVariable -name "TotalFailed" -value $xml_testsfailed
	
	$percentPassed = 0
	if ([int]$xml_totaltests -gt 0) { $percentPassed = [int]$xml_testspassed / [int]$xml_totaltests }
	Set-OctopusVariable -name "TotalPassedPercent" -value ("{0:P0}" -f $percentPassed)

	Set-OctopusVariable -name "TestResult" -value $xml_testresult

	$remoteReportPath = Join-Path -Path $ReportLocation -ChildPath $reportFile
	Write-Host "remoteReportPath: $remoteReportPath"
	$reportUncPath = $remoteReportPath  -replace "^\w:\\*", "\\$env:computername\"
	Write-Host "reportUncPath: $reportUncPath"

	Set-OctopusVariable -name "ReportPath" -value $reportUncPath

	$remoteDir = [System.IO.Path]::GetDirectoryName("$remoteReportPath") + "\"
	Write-Host "Copying report to remote location: $remoteDir"
	Try {
		If (!(Test-Path $remoteDir))
		{
			New-Item -ItemType Directory -Force -Path $remoteDir
		}

		xcopy /F $localReportPath "$remoteDir"
	}
	Catch {
		Write-Host "Copy failed: $_.Exception.Message"
	}
}

$ReportUnitExit = $lastExitCode

IF ($ReportUnitExit -eq 0)
{
 "...HTML Report is succesfully generated..."
	EXIT $ReportUnitExit
}
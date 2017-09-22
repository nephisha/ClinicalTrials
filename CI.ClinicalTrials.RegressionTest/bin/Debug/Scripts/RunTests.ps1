$PackageLocation = "C:\Test"
$NUnitCategory = "Regression"
$OutDir = "C:\Reports"

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

Set-OctopusVariable -name "TotalTests" -value $xml_totaltests
Set-OctopusVariable -name "TotalPassed" -value $xml_testspassed
Set-OctopusVariable -name "TotalFailed" -value $xml_testsfailed

Set-OctopusVariable -name "TestResult" -value $xml_testresult

Write-Host "Running ReportUnit.exe..."

Push-Location "$ResultDir"

$runReportUnit = "& $reportUnitExe TestResult.xml TestResult.html"

Write-Host "Let's execute the ReportUnit XML beautifier..."
 
Invoke-Expression $runReportUnit

Set-OctopusVariable -name "ReportHtmlFile" -value "Reports\$date\TestResult.html"

$ReportUnitExit = $lastExitCode

IF ($ReportUnitExit -eq 0)
{
 "...HTML Report is succesfully generated..."
	EXIT $ReportUnitExit
}
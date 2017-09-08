$PackageLocation = "C:\Test"
$NUnitCategory = "Working"
$OutDir = "C:\Reports"
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
	EXIT $nunitExit
}
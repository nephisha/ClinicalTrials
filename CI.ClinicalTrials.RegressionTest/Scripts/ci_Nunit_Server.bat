ECHO : Running Clinical Trial Tests
set workingDir="%~dp0"
cd..
set targetDir=%cd%
set resultfileroot=C:\Reports
if not exist %resultfileroot% mkdir %resultfileroot%\Screenshot
set year=%date:~10,4%
set month=%date:~7,2%
set day=%date:~4,2%
set min=%time:~3,2%
set min=%min: =%
set hour=%time:~0,2%
set hour=%hour: =%
set root=%resultfileroot%\%~n0-%month%_%day%-%hour%_%min%
md %root%
set xmlfilename=%~n0-%month%_%day%-%hour%_%min%.xml
set txtfilename=%~n0-%month%_%day%-%hour%_%min%.txt
set htmlfilename=%~n0-%month%_%day%-%hour%_%min%.html

"%targetDir%\Tools\NUnit3_Console\nunit3-console.exe" "%targetDir%\CI.ClinicalTrials.RegressionTest.dll" --labels=All --work=%root% --where "cat == Working"

"%targetDir%\Tools\ReportUnit\ReportUnit.exe" "%root%\TestResult.xml" "%root%\TestResult.html"
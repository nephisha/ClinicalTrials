ECHO : Running Clinical Trial Tests using MsTest
set workingDir="%~dp0"
cd../..
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
set filename=%~n0-%month%_%day%-%hour%_%min%.trx
set txtfilename=%~n0-%month%_%day%-%hour%_%min%.txt
set htmlfilename=%~n0-%month%_%day%-%hour%_%min%.html

"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\MSTest.exe"  /category:"Working" /resultsfile:%resultfileroot%\%filename% /testcontainer:"%targetDir%\CI.ClinicalTrials.RegressionTest\bin\Debug\CI.ClinicalTrials.RegressionTest.dll"

"%targetDir%\CI.ClinicalTrials.RegressionTest\Tools\Specflow\specflow.exe" mstestexecutionreport "%targetDir%\CI.ClinicalTrials.RegressionTest\CI.ClinicalTrials.RegressionTest.csproj" /testResult:%resultfileroot%\%filename% /out:%resultfileroot%\%htmlfilename%

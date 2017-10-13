# This script will setup the local database with the connection string referenced in App.config
# to have the user accounts as specified in App.config.

# DO NOT run this script pointing at a production database or somewhere that test users with insecure passwords should not be created.

Push-Location
Import-Module SQLPS
#Import-Module "C:\Program Files\Microsoft SQL Server\110\Tools\PowerShell\Modules\SQLPS"
Pop-Location

if ([System.IO.File]::Exists("./App.config")) { $appConfig = "./App.config" }
elseif ([System.IO.File]::Exists("./CI.ClinicalTrials.RegressionTest.dll.config")) { $appConfig = "./CI.ClinicalTrials.RegressionTest.dll.config" }
else { $appConfig = "./*.config" }

$appConfigDoc = (Get-Content $appConfig) -as [Xml]

$connectionString = ($appConfigDoc.configuration.connectionStrings.add | where { $_.name -eq 'ClinicalTrialsWeb' }).connectionString
#echo $connectionString
$conn = new-object System.Data.SqlClient.SqlConnection("$connectionString")


$appSettings = $appConfigDoc.configuration.appSettings
$adminPassword = ($appSettings.add | where { $_.key -eq 'Admin_Password' }).value
$adminUserName = ($appSettings.add | where { $_.key -eq 'Admin_UserName' }).value
$autoCtuPassword = ($appSettings.add | where { $_.key -eq 'AutoCTU_Password' }).value
$autoCtuUserName = ($appSettings.add | where { $_.key -eq 'AutoCTU_UserName' }).value
$ctuPassword = ($appSettings.add | where { $_.key -eq 'CTU_Password' }).value
$ctuUserName = ($appSettings.add | where { $_.key -eq 'CTU_UserName' }).value

#echo $adminPassword
#echo $adminUserName
#echo $autoCtuPassword
#echo $autoCtuUserName
#echo $ctuPassword
#echo $ctuUserName

Function Ensure-SQL-User
{	
	Param ($username, $password, $role)
	$sqlArgs = "UserName = $username", "Pwd = $password", "Role = $role"
	echo "sqlArgs: $sqlArgs"
	# echo $conn

	$sql = Get-Content "./Scripts/EnsureSqlUsers.sql" -Raw
	Invoke-Sqlcmd -Query "$sql" -ServerInstance $conn.DataSource -Database $conn.Database -Variable $sqlArgs -Verbose
}

Ensure-SQL-User $adminUserName $adminPassword 'Administrator'
Ensure-SQL-User $autoCtuUserName $autoCtuPassword 'CTU'
Ensure-SQL-User $ctuUserName $ctuPassword 'CTU'

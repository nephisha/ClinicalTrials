DECLARE @UserName VARCHAR(50)
DECLARE @Pwd VARCHAR(50)
DECLARE @Role VARCHAR(50)
DECLARE @UserID UNIQUEIDENTIFIER

SET @UserName = '$(UserName)' -- argument from powershell
SET @Pwd = '$(Pwd)' -- argument from powershell
SET @Role = '$(Role)' -- argument from powershell
--SET @UserName = 'TestUser'
--SET @Pwd = 'TestPwd'
--SET @Role = 'CTU'

SELECT 
	@UserID = UserId
FROM
	aspnet_Users
WHERE
	UserName = @UserName

IF (@UserID IS NULL)
BEGIN
	PRINT 'Creating user: ' + @UserName
	declare @now datetime
	set @now= GETDATE()
	DECLARE @email VARCHAR(255)
	SET @email = CAST(NEWID() AS VARCHAR(255)) + '@cancerinstitute.org.au' 

	exec aspnet_Membership_CreateUser '/', @UserName, @Pwd, '', 'test@test.com', '', '', 1, @now, @now, 0, 0, @UserId = @UserId OUTPUT

	INSERT INTO PersonalData (UserId, FirstName, Surname, ReceivePortfolioNotificationEmails)
	VALUES (@UserID, @UserName, @UserName, 0)

	SET @UserID = (SELECT UserId FROM aspnet_Users WHERE UserName = @UserName)
END

-- TODO: set the password
DECLARE @utcNow DATETIME
SET @utcNow = GETUTCDATE()
EXEC aspnet_Membership_SetPassword '/', @UserName, @Pwd, '', @utcNow, 0

DECLARE @RoleId UNIQUEIDENTIFIER
SET @RoleId = (SELECT RoleId FROM aspnet_Roles WHERE RoleName = @Role)
--Print @RoleId

IF (@RoleId IS NULL) 
	PRINT 'Role: ' + @Role + ' not found'
ELSE
BEGIN
	IF NOT EXISTS (SELECT * FROM aspnet_UsersInRoles WHERE UserId = @UserId AND RoleId = @RoleId)
	INSERT INTO aspnet_usersInRoles (UserId, RoleId) VALUES (@UserID, @RoleId)
END
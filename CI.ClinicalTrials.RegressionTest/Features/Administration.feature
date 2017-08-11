Feature: Administration
	In order to restrict the access to various features
	As an Administrator
	I want to create users with multiple roles

@Users
Scenario Outline: 27340 - Create new User
# This will test that you can create three users that match the three different user
# types that the system recognises
	Given I login to Clinical Trial Application as Administrator
	When I create new <UserType> user from the user menu option
	Then I should see the <User> user created successfully

	Examples:
	| UserType | User                  |
	| CTU      | Clinical Trials Unit  |
	| LHD      | Local Health District |

@Users
Scenario: 27347 - Create new Sponsor
	Given I login to Clinical Trial Application as Administrator
	When I create new sponsor from the menu option
	Then I should see the sponsor created successfully

@Users
Scenario: 27352 - Create new Local Health District
	Given I login to Clinical Trial Application as Administrator
	When I create new LHD from the menu option
	Then I should see the LHD created successfully

@Users
Scenario: 27355 - Create new Clinical Trial Unit
	Given I login to Clinical Trial Application as Administrator
	When I create new CTU from the menu option
	Then I should see the CTU created successfully

@Users
Scenario: 27358 - Create new Hospital
	Given I login to Clinical Trial Application as Administrator
	When I create new Hospital from the menu option
	Then I should see the Hospital created successfully

@Users
Scenario: 27369 - Create new Report Period
	Given I login to Clinical Trial Application as Administrator
	When I create new Report Period from the menu option
	Then I should see the Report Period created successfully

@Users
Scenario: 27370 - 27372 - Modify and Delete Report Period
	Given I login to Clinical Trial Application as Administrator
	And I have a existing Report Period
	When I modify the Report Period
	Then I should see the changes made in Report Period
	And When I delete the Report Period
	Then the report period should be deleted successfully

@Users
Scenario: 27389 - Create new Report Period Extension
	Given I login to Clinical Trial Application as Administrator
	When I create new Report Period Extension from the menu option
	Then I should see the Extension created successfully

@Edit
Scenario Outline: 27341 - Editing user details and access
	Given I login to Clinical Trial Application as Administrator
	And I have an existing active <Type1> user
	When I change the <Type1> user access to <Type2> and details
	Then <Type2> user should see the new changes in <Primary Menu> and <Secondary Menu>
		
	Examples:
	| Type1 | Type2 | Primary Menu                                                                                | Secondary Menu                           |
	| CTU   | LHD   | Master Trials, Submit New Trial, Reports                                                    |                                          |
	| LHD   | CTU   | Dashboard, Master Trials, Submit New Trial, My Site Trial, Sign Off My Site Trials, Reports | Extracts, User Resources                 |
	| CTU   | Admin | Dashboard, Master Trials, Submit New Trial, My Site Trial, Sign Off My Site Trials, Reports | Extracts, User Resources, Administration |
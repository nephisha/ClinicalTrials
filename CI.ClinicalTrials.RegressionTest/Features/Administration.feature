﻿Feature: Administration
	In order to restrict the access to various features
	As an Administrator
	I want to create users with multiple roles

@Users @Regression
Scenario Outline: 27340 - Create new User
	Given I login to Clinical Trial Application as Administrator
	When I create new <UserType> user from the user menu option
	Then I should see the <User> user created successfully

	Examples:
	| UserType | User                  |
	| CTU      | Clinical Trials Unit  |
	| LHD      | Local Health District |

@Users @Regression
Scenario: 27347 - Create new Sponsor
	Given I login to Clinical Trial Application as Administrator
	When I create new sponsor from the menu option
	Then I should see the sponsor created successfully

@Users @Regression
Scenario: 27352 - Create new Local Health District
	Given I login to Clinical Trial Application as Administrator
	When I create new LHD from the menu option
	Then I should see the LHD created successfully

@Users @Regression
Scenario: 27355 - Create new Clinical Trial Unit
	Given I login to Clinical Trial Application as Administrator
	When I create new CTU from the menu option
	Then I should see the CTU created successfully

@Users @Regression
Scenario: 27358 - Create new Hospital
	Given I login to Clinical Trial Application as Administrator
	When I create new Hospital from the menu option
	Then I should see the Hospital created successfully

@Users @Regression
Scenario: 27359 - Modify Hospital
	Given I login to Clinical Trial Application as Administrator
	And I have an existing hospital
	When I edit the hospital
	Then I should see the changes made for the hospital

@Users @Regression
Scenario: 27369 - Create new Report Period
	Given I login to Clinical Trial Application as Administrator
	When I create new Report Period from the menu option
	Then I should see the Report Period created successfully

@Users @Regression
Scenario: 27370 - 27372 - Modify and Delete Report Period
	Given I login to Clinical Trial Application as Administrator
	And I have a existing Report Period
	When I modify the Report Period
	Then I should see the changes made in Report Period
	And When I delete the Report Period
	Then the report period should be deleted successfully

@Users @Regression
Scenario: 27389 - Create new Report Period Extension
	Given I login to Clinical Trial Application as Administrator
	When I create new Report Period Extension from the menu option
	Then I should see the Extension created successfully
	And I delete the extension created

@Edit @Regression
Scenario Outline: 27341 - Editing user details and access
	Given I login to Clinical Trial Application as Administrator
	And I have an existing active <Type1> user
	When I change the <Type1> user access to <Type2> and details
	Then <Type2> user should see the new changes
		
	Examples:
	| Type1 | Type2 |
	| CTU   | LHD   |
	| LHD   | CTU   |

#@Edit @Regression
#Scenario Outline: 27341 - Editing user details and access
#	Given I login to Clinical Trial Application as Administrator
#	And I have an existing active <Type1> user
#	When I change the <Type1> user access to <Type2> and details
#	Then <Type2> user should see the new changes in <Primary Menu> and <Secondary Menu>
#		
#	Examples:
#	| Type1 | Type2 | Primary Menu                                                                                | Secondary Menu                           |
#	| CTU   | LHD   | Master Trials, Submit New Trial, Reports                                                    |                                          |
#	| LHD   | CTU   | Dashboard, Master Trials, Submit New Trial, My Site Trial, Sign Off My Site Trials, Reports | Extracts, User Resources                 |
#	| CTU   | Admin | Dashboard, Master Trials, Submit New Trial, My Site Trial, Sign Off My Site Trials, Reports | Extracts, User Resources, Administration |

@Users @Regression
Scenario Outline: 27342 - Disable Existing User
	Given I login to Clinical Trial Application as Administrator
	And I have an existing <CTU User> who is activated
	When I disable the user account
	Then <CTU User> should not be allowed to login the system

	Examples: 
	| CTU User         | Status   |
	| RegressionCTU030 | Disabled |

@Users @Regression
Scenario: 27348 - Edit Sponsor Details
	Given I login to Clinical Trial Application as Administrator
	And I have an existing sponsor
	When I edit the sponsor
	Then I should see the changes made for the sponsor

@Users @Regression
Scenario: 27350 Deprecate Sponsor
	Given I login to Clinical Trial Application as Administrator
	And I have an existing sponsor
	When I deprecate the sponsor
	Then I should not see the sponsor in dropdowns

@Users @Regression
Scenario: 27356 - Edit Clinical Trial Unit Details
	Given I login to Clinical Trial Application as Administrator
	And I have an existing clinical trial unit
	When I edit the clinical trial unit
	Then I should see the changes made for the clinical trial unit

@Users @Regression
Scenario: 27357 Deprecate Clinical Trial Unit
	Given I login to Clinical Trial Application as Administrator
	And I have an existing clinical trial unit
	When I deprecate the clinical trial unit
	Then I should not see the clinical trial unit in dropdowns

@Users @Regression @Working
Scenario: 27354 - Edit Local Health District
	Given I login to Clinical Trial Application as Administrator
	And I have an existing Local Health District
	When I edit the Local Health District
	Then I should see the changes made for the Local Health District

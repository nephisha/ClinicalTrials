Feature: MasterTrialList
	In order to action on a Clinical Trial
	As a User
	I want perform search on the Master Trials

@Search @Regression
Scenario: 27012 - Master Trial List - Basic Search
	Given I login to Clinical Trial Application as CTU User
	When I perform a basic search in Master Trial
	Then I should see the search results

@Search @Regression
Scenario: 27013 - Master Trial List Search By Top Navigation
	Given I login to Clinical Trial Application as CTU User
	When I search in the top navigation bar
	Then I should see the search results

@Search @Regression
Scenario: 27015 - Master Trial List - Search By Sponsor
	Given I login to Clinical Trial Application as CTU User
	When I search by sponsor
	Then I should see the sponsor search results

@Search @Regression
Scenario: 27020 - Master Trial List - Search By CTU
	Given I login to Clinical Trial Application as CTU User
	When I search by CTU
	Then I should see the CTU search results

@Search @Regression
Scenario: 27021 - Master Trial List - Search By Tumour Groups
	Given I login to Clinical Trial Application as CTU User
	When I search by Tumour Groups
	Then I should see the Tumour Group search results

@Search @Regression
Scenario: 27022 - Master Trial List - Search By Trial Classification
	Given I login to Clinical Trial Application as Administrator
	When I search by Trial Classification
	Then I should see the Trial Classification search results

@Search @Regression
Scenario: 27023 - Master Trial List - Search By Verification Status
	Given I login to Clinical Trial Application as Administrator
	When I search by verification status
	Then I should see the verification status search results

@Search @Regression
Scenario: 27043 - Master Trial - Add to My Site Trial
	Given I login to Clinical Trial Application as CTU User
	When I add a trial to my site
	Then I should see the trial added successfully

@Search @Regression
Scenario: 27044 - Master Trial - Edit Trial Details
	Given I login to Clinical Trial Application as Administrator
	When I edit a trial
	Then I should see the trial details added successfully

@Search
Scenario: 27045 - Master Trial - View Locations
	Given I login to Clinical Trial Application as CTU User
	When I select the location tab
	Then I should see the location details

@Search @Regression
Scenario: 27048 - Master Trial - Remove Trial 
	Given I login to Clinical Trial Application as Administrator
	When I remove a trial
	Then I should see the trial getting removed successfully

@Verify @Regression
Scenario: 26999 - Trial Verification - Verify A Trial 
	Given I login to Clinical Trial Application as Administrator
	And I have an existing trial pending for verification
	When I verify the trial
	Then I should see the trial getting verified successfully

@Verify @Regression
Scenario: 27000 - Trial Verification - Reject A Trial 
	Given I login to Clinical Trial Application as Administrator
	And I have an existing trial pending for verification
	When I reject the trial
	Then I should see the trial getting rejected successfully

@Verify @Regression
Scenario: 27001 - Trial Verification - In Review 
	Given I login to Clinical Trial Application as Administrator
	And I have an existing trial pending for verification
	When I review the trial
	Then I should see the trial getting reviewed successfully

@Classify @Regression
Scenario: 27002 - Trial Classification - In Review 
	Given I login to Clinical Trial Application as Administrator
	And I have an existing portfolio trial pending for verification
	When I verify the trial
	Then I should see the trial getting verified successfully
	And When I classify the trial as In Review
	Then I should see the trial classified as In Review successfully

@Classify @Regression
Scenario: 27003 - Trial Classification - Portfolio
	Given I login to Clinical Trial Application as Administrator
	And I have an existing portfolio trial pending for verification
	When I verify the trial
	Then I should see the trial getting verified successfully
	And When I classify the trial as Portfolio
	Then I should see the trial classified as Portfolio successfully

@Classify @Regression
Scenario: 27004 - Trial Classification - NonPortfolio
	Given I login to Clinical Trial Application as Administrator
	And I have an existing portfolio trial pending for verification
	When I verify the trial
	Then I should see the trial getting verified successfully
	And When I classify the trial as Non-Portfolio
	Then I should see the trial classified as Non-Portfolio successfully

@Classify @Regression
Scenario: 27010 - Trial History - Capture Changes
	Given I login to Clinical Trial Application as Administrator
	And I have an existing portfolio trial pending for verification
	When I verify the trial
	Then I should see the trial getting verified successfully
	And When I classify the trial as Portfolio
	Then I should see the trial classified as Portfolio successfully
	When I open the history tab
	Then I should see the history of all changes made into this trial

@Classify @Regression
Scenario: 29523 - Trial Classification - User cannot classify before verification 
	Given I login to Clinical Trial Application as Administrator
	And I have an existing portfolio trial pending for verification
	When I try to classify the trial before verifying it
	Then I should see the error messages
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

@Search @Regression1
Scenario: 27043 - Master Trial - Add to My Site Trial
	Given I login to Clinical Trial Application as CTU User
	When I add a trial to my site
	Then I should see the trial added successfully

@Search @Regression1
Scenario: 27044 - Master Trial - Edit Trial Details
	Given I login to Clinical Trial Application as Administrator
	When I edit a trial
	Then I should see the trial details added successfully

@Search
Scenario: 27045 - Master Trial - View Locations
	Given I login to Clinical Trial Application as CTU User
	When I select the location tab
	Then I should see the location details

@Search @Regression1
Scenario: 27048 - Master Trial - Remove Trial 
	Given I login to Clinical Trial Application as Administrator
	When I remove a trial
	Then I should see the trial getting removed successfully

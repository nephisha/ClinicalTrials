Feature: MySiteTrials
	

@Clinical @Regression
Scenario: 27067 - Display Current Report Period - MySite Trials
	Given I login to Clinical Trial Application as Administrator 
	And I open MySite trials from menu
	When I select a clinical trial unit
	Then the report period details should be displayed

Scenario Outline: 27086 - Remove a Trial from My Site Trials
	Given I login to Clinical Trial Application as CTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the trial added successfully
	And When I remove the trail from my site
	Then I should see the trial removed from my site trials

	Examples: 
	| Category |  Sponsor | Design         |
	| Industry |  Kosan   | Interventional |
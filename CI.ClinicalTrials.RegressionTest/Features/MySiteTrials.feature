Feature: MySiteTrials
	

@Clinical
Scenario: 27067 - Display Current Report Period - MySite Trials
	Given I login to Clinical Trial Application as Administrator 
	And I open MySite trials from menu
	When I select a clinical trial unit
	Then the report period details should be displayed


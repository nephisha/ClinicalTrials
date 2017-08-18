Feature: Reconciliation
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Reconciliation @Regression
Scenario Outline: 27128 - Reconciliation - Approval
	Given I login to Clinical Trial Application as AutomationCTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the created trial added successfully
	When I save the trial data for the trial
	Then I should be able to signoff the trial

	Examples: 
	| Category  | Sponsor    | Design         |
	| Portfolio | ACT Health | Interventional |
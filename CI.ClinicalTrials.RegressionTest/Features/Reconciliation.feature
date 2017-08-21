Feature: Reconciliation
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Reconciliation @Regression
Scenario Outline: 27128 - Reconciliation - Approval
	Given I login to Clinical Trial Application as AutomationCTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	And I LogOff the Clinical Trial Application

	Given I login to Clinical Trial Application as Administrator
	When I verify and classify the trial
	Then I should see the trial classified successfully
	And I LogOff the Clinical Trial Application

	Given I login to Clinical Trial Application as AutomationCTU User
	And I see created trial in MasterTrial List
	When I add the created trial to my site
	Then I should see the created trial added successfully
	When I save the trial data for the trial
	Then I should be able to signoff the trial
	And I LogOff the Clinical Trial Application

	Given I login to Clinical Trial Application as Administrator
	And I should see the signed off trial for reconciliation
	When I approve and finalize the trial
	Then I see the trial finalized successfully

	Examples: 
	| Category  | Sponsor    | Design         |
	| Portfolio | ACT Health | Interventional |
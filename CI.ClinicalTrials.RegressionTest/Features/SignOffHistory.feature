Feature: SignOffHistory
	

@SignOffHistory @Regression @wip
Scenario Outline: 27379 - Signoff History Report
	Given I login to Clinical Trial Application as AutomationCTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the created trial added successfully
	When I save the trial data for the trial
	Then I should be able to signoff the trial
	And I LogOff the Clinical Trial Application
	
	Given I login to Clinical Trial Application as Administrator
	When I see the sign off history page
	Then I should see the sign off date listed for this CTU

	Examples: 
	| Category  | Sponsor    | Design         |
	| Portfolio | ACT Health | Interventional |
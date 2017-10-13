Feature: MySiteTrials
	

@Clinical @Regression
Scenario: 27067 - Display Current Report Period - MySite Trials
	Given I login to Clinical Trial Application as MySiteAdministrator 
	And I open MySite trials from menu
	When I select a clinical trial unit
	Then the report period details should be displayed

@Regression
Scenario Outline: 27086 - Remove a Trial from My Site Trials
	Given I login to Clinical Trial Application as CTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the created trial added successfully
	And When I remove the trail from my site
	Then I should see the trial removed from my site trials

	Examples: 
	| Category |  Sponsor | Design         |
	| Industry |  Kosan   | Interventional |

@Regression
Scenario Outline: 27087 - Archive a Trial from My Site Trials
	Given I login to Clinical Trial Application as AutomationCTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the created trial added successfully
	And When I abandon the trial from my site
	Then I should be able to archive the trial
	And I should be able to see trial under <TrialCategory> filter

	Examples: 
	| Category     | Sponsor            | Design | TrialCategory |
	| NonPortfolio | Cancer Council NSW | Other  | Archived      |

@Regression
Scenario Outline: 27089 - My Site Trial - Trial data mandatory fields
	Given I login to Clinical Trial Application as AutomationCTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the created trial added successfully
	When I save the trial leaving the trial details blank
	Then I should see the trial detail mandatory error messages
	When I save the trial leaving the participant details blank
	Then I should see the participant detail mandatory error messages

	Examples: 
	| Category     | Sponsor            | Design | TrialCategory |
	| NonPortfolio | Cancer Council NSW | Other  | Archived      |


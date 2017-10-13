Feature: AA Submit a Clinical Trial for the Patient

  In order to participate in clinical trials
  As a User
  I should be able to submit new Trials

  @Clinical @Regression @Test
  Scenario Outline: 26612 - Submit a Portfolio Clinical Trial

    Given I login to Clinical Trial Application as Administrator
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by Administrator

	Examples: 
	| Test | Category  | Sponsor    | Design         |
	| 1    | Portfolio | ACT Health | Interventional |
	| 2    | Portfolio | ACT Health | Interventional |
	| 3    | Portfolio | ACT Health | Interventional |
	| 4    | Portfolio | ACT Health | Interventional |

@Clinical @Regression
  Scenario Outline: 26623 - Submit a Non - Portfolio Clinical Trial

    Given I login to Clinical Trial Application as CTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User

	Examples: 
	| Test | Category     | Sponsor            | Design |
	| 1    | NonPortfolio | Cancer Council NSW | Other  |
	| 2    | NonPortfolio | Cancer Council NSW | Other  |

@Clinical @Regression
  Scenario Outline: 26625 - Submit a Industrial Clinical Trial

    Given I login to Clinical Trial Application as CTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User

	Examples: 
	| Test | Category | Sponsor | Design         |
	| 1    | Industry | Kosan   | Interventional |
	| 2    | Industry | Kosan   | Interventional |

@Clinical @Regression
  Scenario Outline: 26627 - Cancel a Non - Portfolio Clinical Trial

    Given I login to Clinical Trial Application as CTU User
	When I cancel a new trial with entered details <Sponsor> and <Design> and <Category>
	Then the new trial should not get created

	Examples: 
	| Category     |  Sponsor            | Design |
	| NonPortfolio |  Cancer Council NSW | Other  |
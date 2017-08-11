Feature: Submit a Clinical Trial for the Patient

  In order to participate in clinical trials
  As a User
  I should be able to submit new Trials

  @Clinical
  Scenario Outline: 26612 - Submit a Portfolio Clinical Trial

    Given I login to Clinical Trial Application as Administrator
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created successfully

	Examples: 
	| Category  | Sponsor    | Design         |
	| Portfolio | ACT Health | Interventional |

@Clinical
  Scenario Outline: 26623 - Submit a Non - Portfolio Clinical Trial

    Given I login to Clinical Trial Application as CTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created successfully

	Examples: 
	| Category     |  Sponsor            | Design |
	| NonPortfolio |  Cancer Council NSW | Other  |

@Clinical
  Scenario Outline: 26625 - Submit a Industrial Clinical Trial

    Given I login to Clinical Trial Application as CTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created successfully

	Examples: 
	| Category |  Sponsor | Design         |
	| Industry |  Kosan   | Interventional |

@Clinical
  Scenario Outline: 26627 - Cancel a Non - Portfolio Clinical Trial

    Given I login to Clinical Trial Application as CTU User
	When I cancel a new trial with entered details <Sponsor> and <Design> and <Category>
	Then the new trial should not get created

	Examples: 
	| Category     |  Sponsor            | Design |
	| NonPortfolio |  Cancer Council NSW | Other  |
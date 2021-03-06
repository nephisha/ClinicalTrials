﻿Feature: SignOffTrials
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SignOff @Regression
Scenario Outline: 27095 - Trial SignOff - Trial Summary List
	Given I login to Clinical Trial Application as AutomationCTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the created trial added successfully
	When I save the trial data for the trial
	Then I should verify the trial summary details

	Examples: 
	| Category  | Sponsor    | Design         |
	| Portfolio | ACT Health | Interventional |


@SignOff @Regression @Test
Scenario Outline: 27096 - Sign Off Trials for Approval
	Given I login to Clinical Trial Application as AutomationCTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the created trial added successfully
	When I save the trial data for the trial
	Then I should be able to signoff the trial
	And I should not see the sign off option

	Examples: 
	| Category  | Sponsor    | Design         |
	| Portfolio | ACT Health | Interventional |

@SignOff @Regression
Scenario Outline: 27102 - Disable MySite Trials after SignOff
	Given I login to Clinical Trial Application as AutomationCTU User
	When I submit a new trial with details <Sponsor> and <Design> and <Category>
	Then I should see the new trial created by CTU User
	When I add the created trial to my site
	Then I should see the created trial added successfully
	When I save the trial data for the trial
	Then I should be able to signoff the trial
	And When I open the signed off trial in My Site trials
	Then I should see the trial data disabled

	Examples: 
	| Category  | Sponsor    | Design         |
	| Portfolio | ACT Health | Interventional |

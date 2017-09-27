Feature: Dashboard

@Dashboard @Regression
  Scenario: 27110 - Dashboard - Number of days left and last maintained by

  Given I login to Clinical Trial Application as CTU User
  When I select a clinical trial unit
  Then I should see the days left and last updated by details
  
@Dashboard @Regression
  Scenario: 27122 - Dashboard - Recruiting Portfolio by Portfolio Category graph

  Given I login to Clinical Trial Application as Administrator
  And I have an existing portfolio trial pending for verification
  When I verify and classify the trial
  And I add the existing trial to my site
  Then I should see the trial added successfully
  And When I save the trial data for the trial
  And I should see the portfolio trial details in dashboard
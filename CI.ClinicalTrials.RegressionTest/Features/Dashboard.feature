Feature: Dashboard

@Dashboard
  Scenario: 27110 - Dashboard - Number of days left and last maintained by

  Given I login to Clinical Trial Application as CTU User
  When I select a clinical trial unit
  Then I should see the days left and last updated by details
  
@MasterTrial
  Scenario Outline: As Admin I needs to view the MasterTrial List

  Given I login to Clinical Trial Application with <UserName> and <Password>
  And I see the Master Trial List

    Examples: 
  | UserName            | Password    |
  | Emmanuel Russel | Welcome@123 |
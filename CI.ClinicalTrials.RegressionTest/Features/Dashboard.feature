Feature: Dashboard

@Dashboard
  Scenario Outline: As Admin I needs to view the dashboard

  Given I login to Clinical Trial Application with <UserName> and <Password>
  And I select the <hospital>
  Then I should see the dashboard of the selected hospital

  Examples: 
  | UserName            | Password    | hospital          |
  | Emmanuel Russel | Welcome@123 | Canberra Hospital |


@MasterTrial
  Scenario Outline: As Admin I needs to view the MasterTrial List

  Given I login to Clinical Trial Application with <UserName> and <Password>
  And I see the Master Trial List

    Examples: 
  | UserName            | Password    |
  | Emmanuel Russel | Welcome@123 |
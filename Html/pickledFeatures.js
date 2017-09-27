jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "Administration.feature",
      "Feature": {
        "Name": "Administration",
        "Description": "In order to restrict the access to various features\r\nAs an Administrator\r\nI want to create users with multiple roles",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "UserType",
                    "User"
                  ],
                  "DataRows": [
                    [
                      "CTU",
                      "Clinical Trials Unit"
                    ],
                    [
                      "LHD",
                      "Local Health District"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27340 - Create new User",
            "Slug": "27340---create-new-user",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I create new <UserType> user from the user menu option",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the <User> user created successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27347 - Create new Sponsor",
            "Slug": "27347---create-new-sponsor",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I create new sponsor from the menu option",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the sponsor created successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27352 - Create new Local Health District",
            "Slug": "27352---create-new-local-health-district",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I create new LHD from the menu option",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the LHD created successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27355 - Create new Clinical Trial Unit",
            "Slug": "27355---create-new-clinical-trial-unit",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I create new CTU from the menu option",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the CTU created successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27358 - Create new Hospital",
            "Slug": "27358---create-new-hospital",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I create new Hospital from the menu option",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the Hospital created successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27359 - Modify Hospital",
            "Slug": "27359---modify-hospital",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing hospital",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I edit the hospital",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the changes made for the hospital",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27369 - Create new Report Period",
            "Slug": "27369---create-new-report-period",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I create new Report Period from the menu option",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the Report Period created successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27370 - 27372 - Modify and Delete Report Period",
            "Slug": "27370---27372---modify-and-delete-report-period",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have a existing Report Period",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I modify the Report Period",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the changes made in Report Period",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I delete the Report Period",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the report period should be deleted successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27389 - Create new Report Period Extension",
            "Slug": "27389---create-new-report-period-extension",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I create new Report Period Extension from the menu option",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the Extension created successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I delete the extension created",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Type1",
                    "Type2"
                  ],
                  "DataRows": [
                    [
                      "CTU",
                      "LHD"
                    ],
                    [
                      "LHD",
                      "CTU"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27341 - Editing user details and access",
            "Slug": "27341---editing-user-details-and-access",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing active <Type1> user",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I change the <Type1> user access to <Type2> and details",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "<Type2> user should see the new changes",
                "StepComments": [],
                "AfterLastStepComments": [
                  {
                    "Text": "#@Edit @Regression"
                  },
                  {
                    "Text": "#Scenario Outline: 27341 - Editing user details and access"
                  },
                  {
                    "Text": "#\tGiven I login to Clinical Trial Application as Administrator"
                  },
                  {
                    "Text": "#\tAnd I have an existing active <Type1> user"
                  },
                  {
                    "Text": "#\tWhen I change the <Type1> user access to <Type2> and details"
                  },
                  {
                    "Text": "#\tThen <Type2> user should see the new changes in <Primary Menu> and <Secondary Menu>"
                  },
                  {
                    "Text": "#"
                  },
                  {
                    "Text": "#\tExamples:"
                  },
                  {
                    "Text": "#\t| Type1 | Type2 | Primary Menu                                                                                | Secondary Menu                           |"
                  },
                  {
                    "Text": "#\t| CTU   | LHD   | Master Trials, Submit New Trial, Reports                                                    |                                          |"
                  },
                  {
                    "Text": "#\t| LHD   | CTU   | Dashboard, Master Trials, Submit New Trial, My Site Trial, Sign Off My Site Trials, Reports | Extracts, User Resources                 |"
                  },
                  {
                    "Text": "#\t| CTU   | Admin | Dashboard, Master Trials, Submit New Trial, My Site Trial, Sign Off My Site Trials, Reports | Extracts, User Resources, Administration |"
                  }
                ]
              }
            ],
            "Tags": [
              "@Edit",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "CTU User",
                    "Status"
                  ],
                  "DataRows": [
                    [
                      "RegressionCTU030",
                      "Disabled"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27342 - Disable Existing User",
            "Slug": "27342---disable-existing-user",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing <CTU User> who is activated",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I disable the user account",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "<CTU User> should not be allowed to login the system",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27348 - Edit Sponsor Details",
            "Slug": "27348---edit-sponsor-details",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing sponsor",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I edit the sponsor",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the changes made for the sponsor",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27350 Deprecate Sponsor",
            "Slug": "27350-deprecate-sponsor",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing sponsor",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I deprecate the sponsor",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should not see the sponsor in dropdowns",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27356 - Edit Clinical Trial Unit Details",
            "Slug": "27356---edit-clinical-trial-unit-details",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing clinical trial unit",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I edit the clinical trial unit",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the changes made for the clinical trial unit",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27357 Deprecate Clinical Trial Unit",
            "Slug": "27357-deprecate-clinical-trial-unit",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing clinical trial unit",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I deprecate the clinical trial unit",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should not see the clinical trial unit in dropdowns",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27354 - Edit Local Health District",
            "Slug": "27354---edit-local-health-district",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing Local Health District",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I edit the Local Health District",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the changes made for the Local Health District",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Users",
              "@Regression",
              "@Working"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "Dashboard.feature",
      "Feature": {
        "Name": "Dashboard",
        "Description": "",
        "FeatureElements": [
          {
            "Name": "27110 - Dashboard - Number of days left and last maintained by",
            "Slug": "27110---dashboard---number-of-days-left-and-last-maintained-by",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I select a clinical trial unit",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the days left and last updated by details",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Dashboard",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27122 - Dashboard - Recruiting Portfolio by Portfolio Category graph",
            "Slug": "27122---dashboard---recruiting-portfolio-by-portfolio-category-graph",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing portfolio trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I verify and classify the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I add the existing trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I save the trial data for the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I should see the portfolio trial details in dashboard",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Dashboard",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "MasterTrialList.feature",
      "Feature": {
        "Name": "MasterTrialList",
        "Description": "In order to action on a Clinical Trial\r\nAs a User\r\nI want perform search on the Master Trials",
        "FeatureElements": [
          {
            "Name": "27012 - Master Trial List - Basic Search",
            "Slug": "27012---master-trial-list---basic-search",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I perform a basic search in Master Trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the search results",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27013 - Master Trial List Search By Top Navigation",
            "Slug": "27013---master-trial-list-search-by-top-navigation",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search in the top navigation bar",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the search results",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27015 - Master Trial List - Search By Sponsor",
            "Slug": "27015---master-trial-list---search-by-sponsor",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search by sponsor",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the sponsor search results",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27020 - Master Trial List - Search By CTU",
            "Slug": "27020---master-trial-list---search-by-ctu",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search by CTU",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the CTU search results",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27021 - Master Trial List - Search By Tumour Groups",
            "Slug": "27021---master-trial-list---search-by-tumour-groups",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search by Tumour Groups",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the Tumour Group search results",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27022 - Master Trial List - Search By Trial Classification",
            "Slug": "27022---master-trial-list---search-by-trial-classification",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search by Trial Classification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the Trial Classification search results",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27023 - Master Trial List - Search By Verification Status",
            "Slug": "27023---master-trial-list---search-by-verification-status",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search by verification status",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the verification status search results",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27043 - Master Trial - Add to My Site Trial",
            "Slug": "27043---master-trial---add-to-my-site-trial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add a trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27044 - Master Trial - Edit Trial Details",
            "Slug": "27044---master-trial---edit-trial-details",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I edit a trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial details added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27045 - Master Trial - View Locations",
            "Slug": "27045---master-trial---view-locations",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I select the location tab",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the location details",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27048 - Master Trial - Remove Trial",
            "Slug": "27048---master-trial---remove-trial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I remove a trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial getting removed successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Search",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "26999 - Trial Verification - Verify A Trial",
            "Slug": "26999---trial-verification---verify-a-trial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I verify the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial getting verified successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Verify",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27000 - Trial Verification - Reject A Trial",
            "Slug": "27000---trial-verification---reject-a-trial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I reject the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial getting rejected successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Verify",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27001 - Trial Verification - In Review",
            "Slug": "27001---trial-verification---in-review",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I review the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial getting reviewed successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Verify",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27002 - Trial Classification - In Review",
            "Slug": "27002---trial-classification---in-review",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing portfolio trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I verify the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial getting verified successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I classify the trial as In Review",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial classified as In Review successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Classify",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27003 - Trial Classification - Portfolio",
            "Slug": "27003---trial-classification---portfolio",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing portfolio trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I verify the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial getting verified successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I classify the trial as Portfolio",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial classified as Portfolio successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Classify",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27004 - Trial Classification - NonPortfolio",
            "Slug": "27004---trial-classification---nonportfolio",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing portfolio trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I verify the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial getting verified successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I classify the trial as Non-Portfolio",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial classified as Non-Portfolio successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Classify",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "27010 - Trial History - Capture Changes",
            "Slug": "27010---trial-history---capture-changes",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing portfolio trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I verify the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial getting verified successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I classify the trial as Portfolio",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial classified as Portfolio successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I open the history tab",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the history of all changes made into this trial",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Classify",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Name": "29523 - Trial Classification - User cannot classify before verification",
            "Slug": "29523---trial-classification---user-cannot-classify-before-verification",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have an existing portfolio trial pending for verification",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I try to classify the trial before verifying it",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the error messages",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Classify",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "MySiteTrials.feature",
      "Feature": {
        "Name": "MySiteTrials",
        "Description": "",
        "FeatureElements": [
          {
            "Name": "27067 - Display Current Report Period - MySite Trials",
            "Slug": "27067---display-current-report-period---mysite-trials",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I open MySite trials from menu",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I select a clinical trial unit",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the report period details should be displayed",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Clinical",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "Industry",
                      "Kosan",
                      "Interventional"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27086 - Remove a Trial from My Site Trials",
            "Slug": "27086---remove-a-trial-from-my-site-trials",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add the created trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the created trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I remove the trail from my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial removed from my site trials",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design",
                    "TrialCategory"
                  ],
                  "DataRows": [
                    [
                      "NonPortfolio",
                      "Cancer Council NSW",
                      "Other",
                      "Archived"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27087 - Archive a Trial from My Site Trials",
            "Slug": "27087---archive-a-trial-from-my-site-trials",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as AutomationCTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add the created trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the created trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I abandon the trial from my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be able to archive the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I should be able to see trial under <TrialCategory> filter",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design",
                    "TrialCategory"
                  ],
                  "DataRows": [
                    [
                      "NonPortfolio",
                      "Cancer Council NSW",
                      "Other",
                      "Archived"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27089 - My Site Trial - Trial data mandatory fields",
            "Slug": "27089---my-site-trial---trial-data-mandatory-fields",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as AutomationCTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add the created trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the created trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I save the trial leaving the trial details blank",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial detail mandatory error messages",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I save the trial leaving the participant details blank",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the participant detail mandatory error messages",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "Reconciliation.feature",
      "Feature": {
        "Name": "Reconciliation",
        "Description": "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of two numbers",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "Portfolio",
                      "ACT Health",
                      "Interventional"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27128 - Reconciliation - Approval",
            "Slug": "27128---reconciliation---approval",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as AutomationCTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I LogOff the Clinical Trial Application",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I verify and classify the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial classified successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I LogOff the Clinical Trial Application",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as AutomationCTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I see created trial in MasterTrial List",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add the created trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the created trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I save the trial data for the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be able to signoff the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I LogOff the Clinical Trial Application",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I should see the signed off trial for reconciliation",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I approve and finalize the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I see the trial finalized successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Reconciliation",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "SignOffHistory.feature",
      "Feature": {
        "Name": "SignOffHistory",
        "Description": "",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "Portfolio",
                      "ACT Health",
                      "Interventional"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27379 - Signoff History Report",
            "Slug": "27379---signoff-history-report",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as AutomationCTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add the created trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the created trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I save the trial data for the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be able to signoff the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I LogOff the Clinical Trial Application",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I see the sign off history page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the sign off date listed for this CTU",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@SignOffHistory",
              "@Regression",
              "@wip"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "SignOffTrials.feature",
      "Feature": {
        "Name": "SignOffTrials",
        "Description": "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of two numbers",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "Portfolio",
                      "ACT Health",
                      "Interventional"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27095 - Trial SignOff - Trial Summary List",
            "Slug": "27095---trial-signoff---trial-summary-list",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as AutomationCTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add the created trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the created trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I save the trial data for the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should verify the trial summary details",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@SignOff",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "Portfolio",
                      "ACT Health",
                      "Interventional"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27096 - Sign Off Trials for Approval",
            "Slug": "27096---sign-off-trials-for-approval",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as AutomationCTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add the created trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the created trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I save the trial data for the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be able to signoff the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I should not see the sign off option",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@SignOff",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "Portfolio",
                      "ACT Health",
                      "Interventional"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "27102 - Disable MySite Trials after SignOff",
            "Slug": "27102---disable-mysite-trials-after-signoff",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as AutomationCTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add the created trial to my site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the created trial added successfully",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I save the trial data for the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be able to signoff the trial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "When I open the signed off trial in My Site trials",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the trial data disabled",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@SignOff",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "SubmitClinicalTrials.feature",
      "Feature": {
        "Name": "Submit a Clinical Trial for the Patient",
        "Description": "In order to participate in clinical trials\r\nAs a User\r\nI should be able to submit new Trials",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "Portfolio",
                      "ACT Health",
                      "Interventional"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "26612 - Submit a Portfolio Clinical Trial",
            "Slug": "26612---submit-a-portfolio-clinical-trial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by Administrator",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Clinical",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "NonPortfolio",
                      "Cancer Council NSW",
                      "Other"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "26623 - Submit a Non - Portfolio Clinical Trial",
            "Slug": "26623---submit-a-non---portfolio-clinical-trial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Clinical",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "Industry",
                      "Kosan",
                      "Interventional"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "26625 - Submit a Industrial Clinical Trial",
            "Slug": "26625---submit-a-industrial-clinical-trial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I submit a new trial with details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the new trial created by CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Clinical",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Category",
                    "Sponsor",
                    "Design"
                  ],
                  "DataRows": [
                    [
                      "NonPortfolio",
                      "Cancer Council NSW",
                      "Other"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "26627 - Cancel a Non - Portfolio Clinical Trial",
            "Slug": "26627---cancel-a-non---portfolio-clinical-trial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I login to Clinical Trial Application as CTU User",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I cancel a new trial with entered details <Sponsor> and <Design> and <Category>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the new trial should not get created",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Clinical",
              "@Regression"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@Users",
        "Total": 15,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 15
      },
      {
        "Tag": "@Regression",
        "Total": 49,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 49
      },
      {
        "Tag": "@Edit",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      },
      {
        "Tag": "@Working",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      },
      {
        "Tag": "@Dashboard",
        "Total": 2,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 2
      },
      {
        "Tag": "@Search",
        "Total": 11,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 11
      },
      {
        "Tag": "@Verify",
        "Total": 3,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 3
      },
      {
        "Tag": "@Classify",
        "Total": 5,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 5
      },
      {
        "Tag": "@Clinical",
        "Total": 5,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 5
      },
      {
        "Tag": "@Reconciliation",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      },
      {
        "Tag": "@SignOffHistory",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      },
      {
        "Tag": "@wip",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      },
      {
        "Tag": "@SignOff",
        "Total": 3,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 3
      }
    ],
    "Folders": [
      {
        "Folder": "Administration.feature",
        "Total": 16,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 16
      },
      {
        "Folder": "Dashboard.feature",
        "Total": 2,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 2
      },
      {
        "Folder": "MasterTrialList.feature",
        "Total": 19,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 19
      },
      {
        "Folder": "MySiteTrials.feature",
        "Total": 4,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 4
      },
      {
        "Folder": "Reconciliation.feature",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      },
      {
        "Folder": "SignOffHistory.feature",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      },
      {
        "Folder": "SignOffTrials.feature",
        "Total": 3,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 3
      },
      {
        "Folder": "SubmitClinicalTrials.feature",
        "Total": 4,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 4
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "Administration.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "Dashboard.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "MasterTrialList.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "MySiteTrials.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "Reconciliation.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "SignOffHistory.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "SignOffTrials.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "SubmitClinicalTrials.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 50,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 50
    },
    "Features": {
      "Total": 8,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 8
    }
  },
  "Configuration": {
    "GeneratedOn": "27 September 2017 16:25:31"
  }
});
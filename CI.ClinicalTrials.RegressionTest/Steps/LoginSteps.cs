using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CI.ClinicalTrials.RegressionTest.Pages;
using CI.ClinicalTrials.RegressionTest.Resources;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private readonly LoginPage loginPage = new LoginPage();
        
        [Given(@"I login to Clinical Trial Application as Administrator")]
        public void GivenILoginToClinicalTrialApplicationAsAdministrator()
        {
            loginPage.LaunchTheApplication();
            loginPage.LoginToApplication(UserCredentials.Admin_UserName, UserCredentials.Admin_Password);
        }

        [Given(@"I login to Clinical Trial Application as CTU User")]
        public void GivenILoginToClinicalTrialApplicationAsCTUUser()
        {
            loginPage.LaunchTheApplication();
            loginPage.LoginToApplication(UserCredentials.CTU_UserName, UserCredentials.CTU_Password);
        }

        [Given(@"I login to Clinical Trial Application as AutomationCTU User")]
        public void GivenILoginToClinicalTrialApplicationAsAutomationCTUUser()
        {
            loginPage.LaunchTheApplication();
            loginPage.LoginToApplication(UserCredentials.AutoCTU_UserName, UserCredentials.AutoCTU_Password);
        }

    }
}

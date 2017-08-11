using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CI.ClinicalTrials.RegressionTest.Pages;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public sealed class MySiteTrialSteps
    {
        private readonly MenuPage menuPage = new MenuPage();
        private readonly MySiteTrialsPage mySiteTrialsPage = new MySiteTrialsPage();

        [Given(@"I open MySite trials from menu")]
        public void GivenIOpenMySiteTrialsFromMenu()
        {
            menuPage.SelectMySiteTrialsFromToggleMenu();
        }

        [When(@"I select a clinical trial unit")]
        public void WhenISelectAClinicalTrialUnit()
        {
            mySiteTrialsPage.SelectAClinicalTrialUnit();
        }

        [Then(@"the report period details should be displayed")]
        public void ThenTheReportPeriodDetailsShouldBeDisplayed()
        {
            mySiteTrialsPage.VerifyReportPeriodDetails();
        }
    }
}

using System;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class SignOffTrialsSteps
    {
        private readonly UI_TestContext context;

        public SignOffTrialsSteps(UI_TestContext context)
        {
            this.context = context;
        }

        private readonly MenuPage menuPage = new MenuPage();
        private readonly SignOffMySiteTrialsPage signOffMySiteTrialsPage = new SignOffMySiteTrialsPage();

        [Then(@"I should be able to signoff the trial")]
        public void ThenIShouldBeAbleToSignoffTheTrial()
        {
            menuPage.SelectSignOffMySiteTrialsFromToggleMenu();
            signOffMySiteTrialsPage.SearchAndSignOffTrials(context.TrialTitle);
            signOffMySiteTrialsPage.VerifySignedOffTrials(context.TrialTitle);
        }

        [Then(@"I should verify the trial summary details")]
        public void ThenIShouldVerifyTheTrialSummaryDetails()
        {
            menuPage.SelectSignOffMySiteTrialsFromToggleMenu();
            signOffMySiteTrialsPage.VerifyTrialSummaryDetails(context.TrialTitle);
        }

        [Then(@"I should not see the sign off option")]
        public void ThenIShouldNotSeeTheSignOffOption()
        {
            signOffMySiteTrialsPage.IsSignOffOptionDisplayed().Should().BeFalse();
        }

    }
}

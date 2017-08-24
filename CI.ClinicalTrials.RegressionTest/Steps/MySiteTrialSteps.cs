using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public sealed class MySiteTrialSteps
    {
        private readonly UI_TestContext context;

        public MySiteTrialSteps(UI_TestContext context)
        {
            this.context = context;
        }

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

        [Then(@"When I remove the trail from my site")]
        public void ThenWhenIRemoveTheTrailFromMySite()
        {
            mySiteTrialsPage.RemoveATrial(context.TrialTitle);
        }

        [Then(@"the report period details should be displayed")]
        public void ThenTheReportPeriodDetailsShouldBeDisplayed()
        {
            mySiteTrialsPage.VerifyReportPeriodDetails();
        }

        [Then(@"I should see the trial removed from my site trials")]
        public void ThenIShouldSeeTheTrialRemovedFromMySiteTrials()
        {
            mySiteTrialsPage.SearchAndVerifyTheRemovedTrial(context.TrialTitle);
        }

        [Then(@"When I abandon the trial from my site")]
        public void ThenWhenIAbandonTheTrialFromMySite()
        {
            mySiteTrialsPage.AbandonTheCreatedTrial(context.TrialTitle);
        }

        [Then(@"I should be able to archive the trial")]
        public void ThenIShouldBeAbleToArchiveTheTrial()
        {
            mySiteTrialsPage.ArchiveTheAbandonedTrial(context.TrialTitle);
        }

        [Then(@"I should be able to see trial under (.*) filter")]
        public void ThenIShouldBeAbleToSeeTrialUnderFilter(string filter)
        {
            mySiteTrialsPage.ApplyFilterAndVerifyTrialData(filter, context.TrialTitle);
        }

        [When(@"I save the trial data for the trial")]
        public void WhenISaveTheTrialDataForTheTrial()
        {
            mySiteTrialsPage.FillinTrialDataAndSave(context.TrialTitle);
        }

        [Then(@"When I open the signed off trial in My Site trials")]
        public void ThenWhenIOpenTheSignedOffTrialInMySiteTrials()
        {
            menuPage.SelectMySiteTrialsFromToggleMenu();
            mySiteTrialsPage.SearchAndOpenTheSignedOffTrial(context.TrialTitle);
        }

        [Then(@"I should see the trial data disabled")]
        public void ThenIShouldSeeTheTrialDataDisabled()
        {
            mySiteTrialsPage.VerifyTheTrialDataIsDisabled();
        }

        [When(@"I save the trial leaving the trial details blank")]
        public void WhenISaveTheTrialLeavingTheTrialDetailsBlank()
        {
            mySiteTrialsPage.SaveEmptyTrialDetails();
        }

        [Then(@"I should see the trial detail mandatory error messages")]
        public void ThenIShouldSeeTheTrialDetailMandatoryErrorMessages()
        {
            mySiteTrialsPage.VerifyTrialDetailMandatoryErrorMessages();
        }

        [When(@"I save the trial leaving the participant details blank")]
        public void WhenISaveTheTrialLeavingTheParticipantDetailsBlank()
        {
            mySiteTrialsPage.FillInTrialDateAndActivityDetails();
            mySiteTrialsPage.SaveEmptyParticipantDetails();
        }

        [Then(@"I should see the participant detail mandatory error messages")]
        public void ThenIShouldSeeTheParticipantDetailMandatoryErrorMessages()
        {
            mySiteTrialsPage.VerifyParticipantMandatoryErrorMessages();
        }
    }
}

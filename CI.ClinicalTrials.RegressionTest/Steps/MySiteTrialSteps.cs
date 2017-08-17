﻿using System;
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
    }
}

﻿using System;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class MasterTrialListSteps
    {
        private readonly UI_TestContext context;
        private readonly LoginSteps loginSteps = new LoginSteps();
        private readonly HomePage homePage = new HomePage();
        private readonly MenuPage menuPage = new MenuPage();
        private readonly MySiteTrialsPage mySiteTrialsPage = new MySiteTrialsPage();
        private readonly SubmitTrialDetailsPage submitTrialDetailsPage = new SubmitTrialDetailsPage();
        private readonly MasterTrialListSearchPage masterTrialListSearchPage = new MasterTrialListSearchPage();

        public MasterTrialListSteps(UI_TestContext context)
        {
            this.context = context;
        }

        [When(@"I perform a basic search in Master Trial")]
        public void WhenIPerformABasicSearchInMasterTrial()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.SearchByQuery();
        }

        [Given(@"I see created trial in MasterTrial List")]
        public void GivenISeeCreatedTrialInMasterTrialList()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
        }

        [Then(@"I should see the search results")]
        public void ThenIShouldSeeTheSearchResults()
        {
            masterTrialListSearchPage.VerifyMasterTrialListSearchPageIsLoaded();
            masterTrialListSearchPage.VerifySearchResults();
        }

        [When(@"I search in the top navigation bar")]
        public void WhenISearchInTheTopNavigationBar()
        {
            homePage.SearchByTopNavigationMenu();
        }
        
        [When(@"I search by sponsor")]
        public void WhenISearchBySponsor()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.SearchBySponsor();
        }

        [Then(@"I should see the sponsor search results")]
        public void ThenIShouldSeeTheSponsorSearchResults()
        {
            masterTrialListSearchPage.VerifySponsorSearchResults();
        }

        [When(@"I search by CTU")]
        public void WhenISearchByCTU()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.SearchByCTU();
        }

        [Then(@"I should see the CTU search results")]
        public void ThenIShouldSeeTheCTUSearchResults()
        {
            masterTrialListSearchPage.VerifyCTUSearchResults();
        }
        
        [When(@"I search by Tumour Groups")]
        public void WhenISearchByTumourGroups()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.SearchByTumourGroups();
        }

        [Then(@"I should see the Tumour Group search results")]
        public void ThenIShouldSeeTheTumourGroupSearchResults()
        {
            masterTrialListSearchPage.VerifyTumourGroupResults();
        }

        [When(@"I search by Trial Classification")]
        public void WhenISearchByTrialClassification()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.SearchByTrialClassification();
        }

        [Then(@"I should see the Trial Classification search results")]
        public void ThenIShouldSeeTheTrialClassificationSearchResults()
        {
            masterTrialListSearchPage.VerifyClassificationSearchResults();
        }

        [When(@"I search by verification status")]
        public void WhenISearchByVerificationStatus()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.SearchByVerificationStatus();
        }

        [Then(@"I should see the verification status search results")]
        public void ThenIShouldSeeTheVerificationStatusSearchResults()
        {
            masterTrialListSearchPage.VerifyVerificationStatusSearchResults();
        }

        [When(@"I add a trial to my site")]
        public void WhenIAddATrialToMySite()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            context.Acronym = masterTrialListSearchPage.AddTrialToMySiteTrialList();
        }

        [When(@"I add the created trial to my site")]
        public void WhenIAddTheCreatedTrialToMySite()
        {
            masterTrialListSearchPage.AddCreatedTrialToMySiteTrial(context.TrialTitle);
        }

        [Then(@"I should see the created trial added successfully")]
        public void ThenIShouldSeeTheCreatedTrialAddedSuccessfully()
        {
            mySiteTrialsPage.SearchAndVerifyTheCreatedTrial(context.TrialTitle);
        }

        [Then(@"I should see the trial added successfully")]
        public void ThenIShouldSeeTheTrialAddedSuccessfully()
        {
            mySiteTrialsPage.SearchAndVerifyTheAddedTrial(context.Acronym);
        }

        [When(@"I edit a trial")]
        public void WhenIEditATrial()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.EditanExistingTrial();
            submitTrialDetailsPage.SaveTheEditedTrial();
        }

        [Then(@"I should see the trial details added successfully")]
        public void ThenIShouldSeeTheTrialDetailsAddedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheEditedTrial();
        }
        
        [When(@"I remove a trial")]
        public void WhenIRemoveATrial()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.RemoveAnExistingTrial();
        }

        [Then(@"I should see the trial getting removed successfully")]
        public void ThenIShouldSeeTheTrialGettingRemovedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheRemovedTrial();
        }

        [When(@"I select the location tab")]
        public void WhenISelectTheLocationTab()
        {
            
        }

        [Then(@"I should see the location details")]
        public void ThenIShouldSeeTheLocationDetails()
        {
            
        }

        [When(@"I verify and classify the trial")]
        public void WhenIVerifyAndClassifyTheTrial()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.VerifyAndClassifyTheTrial(context.TrialTitle);
        }

        [Then(@"I should see the trial classified successfully")]
        public void ThenIShouldSeeTheTrialClassifiedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheClassifiedTrial(context.TrialTitle);
        }

        [Then(@"as an Admin I should be able to verify and classify the trial")]
        public void ThenAsAnAdminIShouldBeAbleToVerifyAndClassifyTheTrial()
        {
            menuPage.LogOffTheApplication();
            loginSteps.GivenILoginToClinicalTrialApplicationAsAdministrator();
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.VerifyAndClassifyTheTrial(context.TrialTitle);
            menuPage.LogOffTheApplication();
        }
    }
}

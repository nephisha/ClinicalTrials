using System;
using CI.ClinicalTrials.RegressionTest.Pages;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class MasterTrialListSteps
    {
        
        private readonly HomePage homePage = new HomePage();
        private readonly MenuPage menuPage = new MenuPage();
        private readonly MySiteTrialsPage mySiteTrialsPage = new MySiteTrialsPage();
        private readonly SubmitTrialDetailsPage submitTrialDetailsPage = new SubmitTrialDetailsPage();
        private readonly MasterTrialListSearchPage masterTrialListSearchPage = new MasterTrialListSearchPage();
        

        [When(@"I perform a basic search in Master Trial")]
        public void WhenIPerformABasicSearchInMasterTrial()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.SearchByQuery();
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
            masterTrialListSearchPage.AddTrialToMySiteTrialList();
        }

        [When(@"I add the created trial to my site")]
        public void WhenIAddTheCreatedTrialToMySite()
        {
            var trialTitle = new SubmitAClinicalTrialForThePatientSteps()._title;
            masterTrialListSearchPage.AddCreatedTrialToMySiteTrial(trialTitle);
        }


        [Then(@"I should see the trial added successfully")]
        public void ThenIShouldSeeTheTrialAddedSuccessfully()
        {
            mySiteTrialsPage.SearchAndVerifyTheAddedTrial();
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
    }
}

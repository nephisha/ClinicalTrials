using System;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using FluentAssertions;
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

        [Then(@"I should not see the sponsor in dropdowns")]
        public void ThenIShouldNotSeeTheSponsorInDropdowns()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            Console.WriteLine(context.DeprecatedSponsor);
            masterTrialListSearchPage.VerifyDeprecatedSponsorIsNotListed(context.DeprecatedSponsor).Should().BeTrue();
        }

        [Then(@"I should not see the clinical trial unit in dropdowns")]
        public void ThenIShouldNotSeeTheClinicalTrialUnitInDropdowns()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            Console.WriteLine(context.DeprecatedCTU);
            masterTrialListSearchPage.VerifyDeprecatedCTUIsNotListed(context.DeprecatedCTU).Should().BeTrue();
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

        [When(@"I search a portfolio trial")]
        public void WhenISearchAPortfolioTrial()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            context.TrialTitle = masterTrialListSearchPage.SearchForPortfolioPendingVerificationTrials();
            Console.WriteLine(context.TrialTitle);
        }

        [When(@"I add a trial to my site")]
        public void WhenIAddATrialToMySite()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            context.Acronym = masterTrialListSearchPage.AddTrialToMySiteTrialList();
            Console.WriteLine(context.Acronym);
        }

        [When(@"I add the existing trial to my site")]
        public void WhenIAddTheExistingTrialToMySite()
        {
            masterTrialListSearchPage.AddCreatedTrialToMySiteTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
        }

        [When(@"I add the created trial to my site")]
        public void WhenIAddTheCreatedTrialToMySite()
        {
            masterTrialListSearchPage.AddCreatedTrialToMySiteTrial(context.TrialTitle);
            Console.WriteLine(context.TrialTitle);
        }

        [Then(@"I should see the created trial added successfully")]
        public void ThenIShouldSeeTheCreatedTrialAddedSuccessfully()
        {
            mySiteTrialsPage.SearchAndVerifyTheCreatedTrial(context.TrialTitle);
            Console.WriteLine(context.TrialTitle);
        }

        [Then(@"I should see the trial added successfully")]
        public void ThenIShouldSeeTheTrialAddedSuccessfully()
        {
            mySiteTrialsPage.SearchAndVerifyTheAddedTrial(context.Acronym);
            Console.WriteLine(context.Acronym);
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
            masterTrialListSearchPage.VerifyAndClassifyTheTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
        }

        [Then(@"I should see the trial classified successfully")]
        public void ThenIShouldSeeTheTrialClassifiedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheClassifiedTrial(context.TrialTitle);
            Console.WriteLine(context.TrialTitle);
        }

        [Then(@"as an Admin I should be able to verify and classify the trial")]
        public void ThenAsAnAdminIShouldBeAbleToVerifyAndClassifyTheTrial()
        {
            menuPage.LogOffTheApplication();
            loginSteps.GivenILoginToClinicalTrialApplicationAsAdministrator();
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.VerifyAndClassifyTheTrial(context.TrialTitle);
            Console.WriteLine(context.TrialTitle);
            menuPage.LogOffTheApplication();
        }

        [Given(@"I have an existing trial pending for verification")]
        public void GivenIHaveAnExistingTrialPendingForVerification()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            context.SelectedTrial = masterTrialListSearchPage.SearchForPendingVerificationTrials();
            Console.WriteLine(context.SelectedTrial);
        }

        [Given(@"I have an existing portfolio trial pending for verification")]
        public void GivenIHaveAnExistingPortfolioTrialPendingForVerification()
        {
            menuPage.SelectMasterTrialFromToggleMenu();
            context.SelectedTrial = masterTrialListSearchPage.SearchForPortfolioPendingVerificationTrials();
            context.Acronym = context.SelectedTrial;
            Console.WriteLine(context.SelectedTrial);
        }

        [When(@"I verify the trial")]
        public void WhenIVerifyTheTrial()
        {
            masterTrialListSearchPage.SearchAndEditTheSelectedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
            masterTrialListSearchPage.VerifyTheTrial();
        }

        [Then(@"I should see the trial getting verified successfully")]
        public void ThenIShouldSeeTheTrialGettingVerifiedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheVerifiedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
        }

        [When(@"I reject the trial")]
        public void WhenIRejectTheTrial()
        {
            masterTrialListSearchPage.SearchAndEditTheSelectedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
            masterTrialListSearchPage.RejectTheTrial();
        }

        [Then(@"I should see the trial getting rejected successfully")]
        public void ThenIShouldSeeTheTrialGettingRejectedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheRejectedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
        }

        [When(@"I review the trial")]
        public void WhenIReviewTheTrial()
        {
            masterTrialListSearchPage.SearchAndEditTheSelectedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
            masterTrialListSearchPage.ReviewTheTrial();
        }

        [Then(@"I should see the trial getting reviewed successfully")]
        public void ThenIShouldSeeTheTrialGettingReviewedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheReviewedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
        }

        [Then(@"When I classify the trial as In Review")]
        public void ThenWhenIClassifyTheTrialAsInReview()
        {
            masterTrialListSearchPage.SearchAndEditTheSelectedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
            masterTrialListSearchPage.ClassifyTheVerifiedTrialAsInReview();
        }

        [Then(@"I should see the trial classified as In Review successfully")]
        public void ThenIShouldSeeTheTrialClassifiedAsInReviewSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheClassifiedTrialStatus(context.SelectedTrial, "In Review");
            Console.WriteLine(context.SelectedTrial);
        }

        [Then(@"When I classify the trial as Portfolio")]
        public void ThenWhenIClassifyTheTrialAsPortfolio()
        {
            masterTrialListSearchPage.SearchAndEditTheSelectedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
            masterTrialListSearchPage.ClassifyTheVerifiedTrialAsPortfolio();
        }

        [Then(@"I should see the trial classified as Portfolio successfully")]
        public void ThenIShouldSeeTheTrialClassifiedAsPortfolioSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheClassifiedTrialStatus(context.SelectedTrial, "Portfolio");
            Console.WriteLine(context.SelectedTrial);
        }

        [Then(@"When I classify the trial as Non-Portfolio")]
        public void ThenWhenIClassifyTheTrialAsNon_Portfolio()
        {
            masterTrialListSearchPage.SearchAndEditTheSelectedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
            masterTrialListSearchPage.ClassifyTheVerifiedTrialAsNonPortfolio();
        }

        [Then(@"I should see the trial classified as Non-Portfolio successfully")]
        public void ThenIShouldSeeTheTrialClassifiedAsNon_PortfolioSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheClassifiedTrialStatus(context.SelectedTrial, "Non-Portfolio");
            Console.WriteLine(context.SelectedTrial);
        }

        [When(@"I try to classify the trial before verifying it")]
        public void WhenITryToClassifyTheTrialBeforeVerifyingIt()
        {
            masterTrialListSearchPage.SearchAndEditTheSelectedTrial(context.SelectedTrial);
            Console.WriteLine(context.SelectedTrial);
            masterTrialListSearchPage.ClassifyTheTrial();
        }

        [Then(@"I should see the error messages")]
        public void ThenIShouldSeeTheErrorMessages()
        {
            masterTrialListSearchPage.VerifyThatTrialSubmissionErrorIsDisplayed();
        }

        [When(@"I open the history tab")]
        public void WhenIOpenTheHistoryTab()
        {
            
        }

        [Then(@"I should see the history of all changes made into this trial")]
        public void ThenIShouldSeeTheHistoryOfAllChangesMadeIntoThisTrial()
        {
            
        }

    }
}

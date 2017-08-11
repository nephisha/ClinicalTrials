using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using CI.ClinicalTrials.RegressionTest.Resources;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class SubmitAClinicalTrialForThePatientSteps
    {
        private readonly MenuPage menuPage = new MenuPage();
        private readonly SubmitTrialDetailsPage submitTrialDetailsPage = new SubmitTrialDetailsPage();
        private readonly MasterTrialListSearchPage masterTrialListSearchPage = new MasterTrialListSearchPage();
        private readonly MySiteTrialsPage mySiteTrialsPage = new MySiteTrialsPage();

        private readonly string _title = "RegTest_" + PageHelper.RandomString(8);

        [When(@"I submit a new trial with details (.*) and (.*) and (.*)")]
        public void WhenISubmitANewTrialWithDetails(string sponsor, string design, string category)
        {
            menuPage.ClickOnToggleMenu();
            menuPage.SelectSubmitATrialFromToggleMenu();
            submitTrialDetailsPage.FillallTheTrialDetails(_title, sponsor, design, category);
            submitTrialDetailsPage.SubmitTrial();
        }

        [When(@"I cancel a new trial with entered details (.*) and (.*) and (.*)")]
        public void WhenICancelANewTrialWithEnteredDetails(string sponsor, string design, string category)
        {
            menuPage.ClickOnToggleMenu();
            menuPage.SelectSubmitATrialFromToggleMenu();
            submitTrialDetailsPage.FillallTheTrialDetails(_title, sponsor, design, category);
            submitTrialDetailsPage.CancelTrial();
        }

        [Then(@"I should see the new trial created successfully")]
        public void ThenIShouldSeeTheNewTrialCreatedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheCreatedTrial(_title);
        }

        [Then(@"I should be shown with Master Trial List page")]
        public void ThenSheShouldBeShownWithMasterTrialListPage()
        {
            masterTrialListSearchPage.VerifyMasterTrialListSearchPageIsLoaded();
        }

        [Then(@"the new trial should not get created")]
        public void ThenTheNewTrialShouldNotGetCreated()
        {
            mySiteTrialsPage.VerifyMySiteTrialsPageIsLoaded();
        }
    }
}

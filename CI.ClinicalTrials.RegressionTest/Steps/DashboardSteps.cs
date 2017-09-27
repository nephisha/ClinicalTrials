using CI.ClinicalTrials.RegressionTest.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class DashboardSteps
    {
        private readonly HomePage homePage = new HomePage();
        private readonly MenuPage menuPage = new MenuPage();
        private readonly MasterTrialListSearchPage masterTrialListSearchPage = new MasterTrialListSearchPage();

        [Given(@"I select the (.*)")]
        public void GivenISelectTheHospital(string hospital)
        {
            homePage.SelectAHospital(hospital);
        }
        
        [Then(@"I should see the dashboard of the selected hospital")]
        public void ThenIShouldSeeTheDashboardOfTheSelectedHospital()
        {
            
        }

        [Given(@"I see the Master Trial List")]
        public void GivenISeeTheMasterTrialList()
        {
            menuPage.ClickOnToggleMenu();
            menuPage.SelectMasterTrialFromToggleMenu();
            masterTrialListSearchPage.VerifyMasterTrialListSearchPageIsLoaded();
        }

        [Then(@"I should see the days left and last updated by details")]
        public void ThenIShouldSeeTheDaysLeftAndLastUpdatedByDetails()
        {
            homePage.VerifyDaysLeftPanel();
            homePage.VerifyLastUpdatedPanel();
        }

        [Then(@"I should see the portfolio trial details in dashboard")]
        public void ThenIShouldSeeThePortfolioTrialDetailsInDashboard()
        {
            menuPage.SelectDashboardFromToggleMenu();
            homePage.VerifyTrialCategoryIsDisplayed().Should().Contain("%");
        }
    }
}

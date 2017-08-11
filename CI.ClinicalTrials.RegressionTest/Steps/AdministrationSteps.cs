using System;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using CI.ClinicalTrials.RegressionTest.Pages.Administrator;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class AdministrationSteps
    {
        private readonly MenuPage menuPage = new MenuPage();
        private readonly UsersPage usersPage = new UsersPage();
        private readonly SponsorPage sponsorPage = new SponsorPage();
        private readonly LHDPage lhdPage = new LHDPage();
        private readonly CTUPage ctuPage = new CTUPage();
        private readonly HospitalPage hospitalPage = new HospitalPage();
        private readonly ReportPeriodPage reportPeriodPage = new ReportPeriodPage();
        private readonly ExtensionsPage extensionsPage = new ExtensionsPage();

        private readonly string editedEmail = PageHelper.EditedEmailAddress();

        [When(@"I create new (.*) user from the user menu option")]
        public void WhenICreateNewUserFromTheUserMenuOption(string user)
        {
            menuPage.SelectUsersFromToggleMenu();
            usersPage.ClickonCreateNewUser();
            usersPage.FillInUserDetailsAndClickCreate(user);
        }

        [Then(@"I should see the (.*) user created successfully")]
        public void ThenIShouldSeeTheUserCreatedSuccessfully(string user)
        {
            usersPage.SearchAndVerifyTheCreatedUser(user);
        }

        [When(@"I create new sponsor from the menu option")]
        public void WhenICreateNewSponsorFromTheUserMenuOption()
        {
            menuPage.SelectSponsorsFromToggleMenu();
            sponsorPage.ClickonCreateNewSponsor();
            sponsorPage.FillInSponsorDetailsAndClickCreate();
        }

        [Then(@"I should see the sponsor created successfully")]
        public void ThenIShouldSeeTheSponsorCreatedSuccessfully()
        {
            sponsorPage.SearchAndVerifyTheCreatedSponsor();
        }

        [When(@"I create new LHD from the menu option")]
        public void WhenICreateNewLhdFromTheUserMenuOption()
        {
            menuPage.SelectLHDsFromToggleMenu();
            lhdPage.ClickonCreateNewLHD();
            lhdPage.FillInLHDDetailsAndClickCreate();
        }

        [Then(@"I should see the LHD created successfully")]
        public void ThenIShouldSeeTheLhdCreatedSuccessfully()
        {
            lhdPage.SearchAndVerifyTheCreatedLHD();
        }

        [When(@"I create new CTU from the menu option")]
        public void WhenICreateNewCtuFromTheUserMenuOption()
        {
            menuPage.SelectCTUsFromToggleMenu();
            ctuPage.ClickonCreateNewCTU();
            ctuPage.FillInCTUDetailsAndClickCreate();
        }

        [Then(@"I should see the CTU created successfully")]
        public void ThenIShouldSeeTheCtuCreatedSuccessfully()
        {
            ctuPage.SearchAndVerifyTheCreatedCTU();
        }

        [When(@"I create new Hospital from the menu option")]
        public void WhenICreateNewHospitalFromTheMenuOption()
        {
            menuPage.SelectHospitalListingFromToggleMenu();
            hospitalPage.ClickonCreateNewHospital();
            hospitalPage.FillInHospitalDetailsAndClickCreate();
        }

        [Then(@"I should see the Hospital created successfully")]
        public void ThenIShouldSeeTheHospitalCreatedSuccessfully()
        {
            hospitalPage.SearchAndVerifyTheCreatedHospital();
        }

        [Given(@"I have an existing active (.*) user")]
        public void GivenIHaveAnExistingActiveUser(string type)
        {
            menuPage.SelectUsersFromToggleMenu();
            usersPage.ClickonCreateNewUser();
            usersPage.FillInUserDetailsAndClickCreate(type);
        }

        [When(@"I change the (.*) user access to (.*) and details")]
        public void WhenIChangeTheUserAccessToAndDetails(string fromUser, string toUser)
        {
            usersPage.SearchAndEditTheCreatedUser(fromUser, toUser, editedEmail);
        }

        [Then(@"(.*) user should see the new changes in (.*)")]
        public void ThenUserShouldSeeTheNewChanges(string type, string[] menu)
        {
            usersPage.SearchAndLoginAsTheEditedUser();
            menuPage.VerifyTheEditedUser(type, editedEmail);
        }

        [When(@"I create new Report Period from the menu option")]
        public void WhenICreateNewReportPeriodFromTheMenuOption()
        {
            menuPage.SelectReportPeriodFromToggleMenu();
            reportPeriodPage.ClickonCreateNewReportPeriod();
            reportPeriodPage.FillInReportPeriodDetailsAndClickCreate();
        }

        [Then(@"I should see the Report Period created successfully")]
        public void ThenIShouldSeeTheReportPeriodCreatedSuccessfully()
        {
            reportPeriodPage.SearchAndVerifyTheCreatedReportPeriod();
        }

        [Given(@"I have a existing Report Period")]
        public void GivenIHaveAExistingReportPeriod()
        {
            menuPage.SelectReportPeriodFromToggleMenu();
            reportPeriodPage.ClickonCreateNewReportPeriod();
            reportPeriodPage.FillInReportPeriodDetailsAndClickCreate();
        }

        [When(@"I modify the Report Period")]
        public void WhenIModifyTheReportPeriod()
        {
            reportPeriodPage.SearchAndEditTheReportPeriod();
        }

        [Then(@"I should see the changes made in Report Period")]
        public void ThenIShouldSeeTheChangesMadeInReportPeriod()
        {
            reportPeriodPage.SearchAndVerifyTheEditedReportPeriod();
        }

        [Then(@"When I delete the Report Period")]
        public void ThenWhenIDeleteTheReportPeriod()
        {
            reportPeriodPage.DeleteTheReportPeriod();
        }


        [Then(@"the report period should be deleted successfully")]
        public void ThenTheReportPeriodShouldBeDeletedSuccessfully()
        {
            reportPeriodPage.SearchAndVerifyTheDeletedReportPeriod();
        }

        [When(@"I create new Report Period Extension from the menu option")]
        public void WhenICreateNewReportPeriodExtensionFromTheMenuOption()
        {
            menuPage.SelectReportPeriodExtensionFromToggleMenu();
            extensionsPage.ClickonCreateNewReportPeriodExtension();
            extensionsPage.FillInExtensionDetailsAndClickCreate();
        }

        [Then(@"I should see the Extension created successfully")]
        public void ThenIShouldSeeTheExtensionCreatedSuccessfully()
        {
            extensionsPage.SearchAndVerifyTheCreatedExtension();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using CI.ClinicalTrials.RegressionTest.Pages.Administrator;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class AdministrationSteps
    {
        private readonly UI_TestContext context;

        public AdministrationSteps(UI_TestContext context)
        {
            this.context = context;
        }

        private readonly LoginPage loginPage = new LoginPage();
        private readonly MenuPage menuPage = new MenuPage();
        private readonly UsersPage usersPage = new UsersPage();
        private readonly SponsorPage sponsorPage = new SponsorPage();
        private readonly LHDPage lhdPage = new LHDPage();
        private readonly CTUPage ctuPage = new CTUPage();
        private readonly HospitalPage hospitalPage = new HospitalPage();
        private readonly ReportPeriodPage reportPeriodPage = new ReportPeriodPage();
        private readonly ExtensionsPage extensionsPage = new ExtensionsPage();
        private readonly EmailLogPage emailLogPage = new EmailLogPage();
        private readonly SignOffHistoryPage signOffHistoryPage = new SignOffHistoryPage();
        
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

        [Given(@"I have an existing sponsor")]
        public void GivenIHaveAnExistingSponsor()
        {
            menuPage.SelectSponsorsFromToggleMenu();
            sponsorPage.ClickonCreateNewSponsor();
            sponsorPage.FillInSponsorDetailsAndClickCreate();
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

        [Given(@"I have an existing Local Health District")]
        public void GivenIHaveAnExistingLocalHealthDistrict()
        {
            menuPage.SelectLHDsFromToggleMenu();
            lhdPage.ClickonCreateNewLHD();
            lhdPage.FillInLHDDetailsAndClickCreate();
        }

        [When(@"I edit the Local Health District")]
        public void WhenIEditTheLocalHealthDistrict()
        {
            lhdPage.SearchAndEditTheLHD();
        }

        [Then(@"I should see the LHD created successfully")]
        public void ThenIShouldSeeTheLhdCreatedSuccessfully()
        {
            lhdPage.SearchAndVerifyTheCreatedLHD();
        }

        [Then(@"I should see the changes made for the Local Health District")]
        public void ThenIShouldSeeTheChangesMadeForTheLocalHealthDistrict()
        {
            lhdPage.SearchAndVerifyTheEditedLHD();
        }

        [When(@"I create new CTU from the menu option")]
        public void WhenICreateNewCtuFromTheUserMenuOption()
        {
            menuPage.SelectCTUsFromToggleMenu();
            ctuPage.ClickonCreateNewCTU();
            ctuPage.FillInCTUDetailsAndClickCreate();
        }

        [Given(@"I have an existing clinical trial unit")]
        public void GivenIHaveAnExistingClinicalTrialUnit()
        {
            menuPage.SelectCTUsFromToggleMenu();
            ctuPage.ClickonCreateNewCTU();
            ctuPage.FillInCTUDetailsAndClickCreate();
        }

        [When(@"I edit the clinical trial unit")]
        public void WhenIEditTheClinicalTrialUnit()
        {
            ctuPage.SearchAndEditTheCTU();
        }

        [Then(@"I should see the changes made for the clinical trial unit")]
        public void ThenIShouldSeeTheChangesMadeForTheClinicalTrialUnit()
        {
            ctuPage.SearchAndVerifyTheEditedCTU();
        }

        [When(@"I deprecate the clinical trial unit")]
        public void WhenIDeprecateTheClinicalTrialUnit()
        {
            context.DeprecatedCTU = ctuPage.DeprecateClinicalTrialUnit();
            Console.WriteLine(context.DeprecatedCTU);
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

        [Given(@"I have an existing hospital")]
        public void GivenIHaveAnExistingHospital()
        {
            menuPage.SelectHospitalListingFromToggleMenu();
            hospitalPage.ClickonCreateNewHospital();
            hospitalPage.FillInHospitalDetailsAndClickCreate();
        }

        [When(@"I edit the hospital")]
        public void WhenIEditTheHospital()
        {
            hospitalPage.SearchAndEditHospital();
        }

        [Then(@"I should see the changes made for the hospital")]
        public void ThenIShouldSeeTheChangesMadeForTheHospital()
        {
            hospitalPage.SearchAndVerifyTheEditedHospital();
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

        [Given(@"I have an existing (.*) who is activated")]
        public void GivenIHaveAnExistingUserWhoIsActivated(string username)
        {
            menuPage.SelectUsersFromToggleMenu();
            usersPage.SearchTheExistingUser(username);
        }


        [Given(@"I have an existing (.*) user who is hh")]
        public void GivenIHaveAnExistingUserWhoIsActgivated(string type)
        {
            menuPage.SelectUsersFromToggleMenu();
            usersPage.ClickonCreateNewUser();
            usersPage.FillInUserDetailsAndClickCreate(type);
            var userName =  usersPage.GetCreatedUserDetails().Item1;
            var email = usersPage.GetCreatedUserDetails().Item2;
            menuPage.SelectEmailLogsFromToggleMenu();
            var link = emailLogPage.GetActivationLink(email);
            menuPage.LogOffTheApplication();
            
        }
        
        [When(@"I disable the user account")]
        public void WhenIDisableTheUserAccount()
        {
            usersPage.DisableTheUser();
        }

        [Then(@"(.*) should not be allowed to login the system")]
        public void ThenCTUUserShouldNotBeAllowedToLoginToTheSystem(string username)
        {
            menuPage.LogOffTheApplication();
            loginPage.LoginToApplication(username, "Welcome@123");
            loginPage.LoginValidationError.Should()
                .BeEquivalentTo("Login was unsuccessful. Please correct the errors and try again.");
        }

        [When(@"I change the (.*) user access to (.*) and details")]
        public void WhenIChangeTheUserAccessToAndDetails(string fromUser, string toUser)
        {
            usersPage.SearchAndEditTheCreatedUser(fromUser, toUser, editedEmail);
        }

        [Then(@"(.*) user should see the new changes")]
        public void ThenUserShouldSeeTheNewChanges(string type)
        {
            usersPage.SearchAndLoginAsTheEditedUser();
            menuPage.VerifyTheEditedUser(type, editedEmail);
        }

        [When(@"I edit the sponsor")]
        public void WhenIEditTheSponsor()
        {
            sponsorPage.SearchAndEditTheCreatedSponsor();
        }

        [Then(@"I should see the changes made for the sponsor")]
        public void ThenIShouldSeeTheChangesMadeForTheSponsor()
        {
            sponsorPage.SearchAndVerifyTheEditedSponsor();
        }

        [When(@"I deprecate the sponsor")]
        public void WhenIDeprecateTheSponsor()
        {
            context.DeprecatedSponsor = sponsorPage.DeprecateASponsor();
            Console.WriteLine(context.DeprecatedSponsor);
        }

        [StepArgumentTransformation]
        public List<string> TransformToListOfString(string commaseperatedlist)
        {
            return commaseperatedlist.Split(',').ToList();
        }
        
        [Then(@"(.*) user should see the new changes in '(.*)' and '(.*)'")]
        public void ThenUserShouldSeeTheNewChanges(string type, List<string> pValues, List<string> sValues)
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

        [Then(@"I delete the extension created")]
        public void ThenIDeleteTheExtensionCreated()
        {
            extensionsPage.DeleteTheCreatedExtension();
        }

        [When(@"I see the sign off history page")]
        public void WhenISeeTheSignOffHistoryPage()
        {
            menuPage.SelectSignOffHistoryFromToggleMenu();
        }

        [Then(@"I should see the sign off date listed for this CTU")]
        public void ThenIShouldSeeTheSignOffDateListedForThisCTU()
        {
            signOffHistoryPage.RunReportForCurrentReportPeriod(context.ReportPeriod);
            signOffHistoryPage.SearchAndVerifySignOffHistoryDetails();
        }
    }
}

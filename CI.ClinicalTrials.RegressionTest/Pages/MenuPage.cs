using System;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class MenuPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "regToggleMenu")]
        private IWebElement ToggleMenu { get; set; }

        [FindsBy(How = How.Id, Using = "regDashboard")]
        private IWebElement Dashboard { get; set; }

        [FindsBy(How = How.Id, Using = "regMasterTrials")]
        private IWebElement MasterTrials { get; set; }

        [FindsBy(How = How.Id, Using = "regSubmitATrial")]
        private IWebElement SubmitATrial { get; set; }

        [FindsBy(How = How.Id, Using = "regMySiteTrial")]
        private IWebElement MySiteTrials { get; set; }

        [FindsBy(How = How.Id, Using = "regSignOffMySite")]
        private IWebElement SignOffMySiteTrials { get; set; }

        [FindsBy(How = How.Id, Using = "regAdministration")]
        private IWebElement Administration { get; set; }

        [FindsBy(How = How.Id, Using = "regUsers")]
        private IWebElement Users { get; set; }

        [FindsBy(How = How.Id, Using = "regSponsors")]
        private IWebElement Sponsors { get; set; }

        [FindsBy(How = How.Id, Using = "regLHDs")]
        private IWebElement LHDs { get; set; }

        [FindsBy(How = How.Id, Using = "regCTUs")]
        private IWebElement CTUs { get; set; }

        [FindsBy(How = How.Id, Using = "regHospitalListing")]
        private IWebElement HospitalListing { get; set; }

        [FindsBy(How = How.Id, Using = "regReportPeriods")]
        private IWebElement ReportPeriods { get; set; }

        [FindsBy(How = How.Id, Using = "regReportPeriodsSubMenu")]
        private IWebElement ReportPeriodsSubMenu { get; set; }

        [FindsBy(How = How.Id, Using = "regExtensions")]
        private IWebElement Extensions { get; set; }

        [FindsBy(How = How.Id, Using = "regSignOffHistory")]
        private IWebElement SignOffHistory { get; set; }

        [FindsBy(How = How.Id, Using = "regReconciliation")]
        private IWebElement Reconciliation { get; set; }

        [FindsBy(How = How.Id, Using = "regAdjustments")]
        private IWebElement Adjustments { get; set; }

        [FindsBy(How = How.Id, Using = "regPayment")]
        private IWebElement Payment { get; set; }

        [FindsBy(How = How.Id, Using = "regPeriodicCoreFunding")]
        private IWebElement PeriodicCoreFunding { get; set; }

        [FindsBy(How = How.Id, Using = "regGlobalAuditHistory")]
        private IWebElement GlobalAuditHistory { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav-tertiary']/li[1]/a")]
        private IWebElement AccountSettings { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement ProfileEmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement ProfileFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "Surname")]
        private IWebElement ProfileSurname { get; set; }

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        private IWebElement ProfilePhoneNumber { get; set; }

        public void ClickOnToggleMenu()
        {
            ToggleMenu.Click();
        }

        public void SelectSubmitATrialFromToggleMenu()
        {
            PageHelper.WaitForElement(Driver, SubmitATrial).Click();
        }

        public void SelectMasterTrialFromToggleMenu()
        {
            PageHelper.WaitForElement(Driver, MasterTrials).Click();
        }

        public void SelectUsersFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, Users).Click();
        }

        public void SelectSponsorsFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, Sponsors).Click();
        }

        public void SelectLHDsFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, LHDs).Click();
        }

        public void SelectCTUsFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, CTUs).Click();
        }

        public void SelectMySiteTrialsFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, MySiteTrials).Click();
        }

        public bool IsMySiteTrialsDisplayed()
        {
            try
            {
                var text = PageHelper.WaitForElement(Driver, MySiteTrials).Text.Equals("My Site Trials");
                return text;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void VerifyTheEditedUser(string type, string editedEmail)
        {
            ClickOnToggleMenu();
            if (type.ToLower().Equals("lhd")) IsMySiteTrialsDisplayed().Should().BeFalse();
            else IsMySiteTrialsDisplayed().Should().BeTrue();

            PageHelper.WaitForElement(Driver, AccountSettings).Click();
            ProfileEmailAddress.GetAttribute("value").Should().BeEquivalentTo(editedEmail);
        }

        public void SelectHospitalListingFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, HospitalListing).Click();
        }

        public void SelectReportPeriodFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, ReportPeriods).Click();
            PageHelper.WaitForElement(Driver, ReportPeriodsSubMenu).Click();
        }

        public void SelectReportPeriodExtensionFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, ReportPeriods).Click();
            PageHelper.WaitForElement(Driver, Extensions).Click();
        }
    }
}

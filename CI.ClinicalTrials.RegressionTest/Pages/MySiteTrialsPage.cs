using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using OpenQA.Selenium.Support.Extensions;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class MySiteTrialsPage : PageBase
    {
        [FindsBy(How = How.XPath, Using = "//legend[@class='clearfix']/div/h1")]
        private IWebElement MySiteTrialsTitle { get; set; }

        [FindsBy(How = How.Id, Using = "legend-sites")]
        private IWebElement CTUDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "reporting-period-heading")]
        private IWebElement ReportPeriodHeading { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement MySiteTrialsSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialList']/tbody/tr[1]/td[2]")]
        private IWebElement CTUMySiteTrialResult_Acronym { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialList']/tbody/tr[1]/td[5]")]
        private IWebElement CTUMySiteTrialResult_Title { get; set; }

        [FindsBy(How = How.Id, Using = "rbtnExact")]
        private IWebElement SiteTarget_Exact_RadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Site_Target")]
        private IWebElement SiteTarget_Exact_Input { get; set; }

        [FindsBy(How = How.Id, Using = "regSiteTarget_ExactDropdown")]
        private IWebElement SiteTarget_ExactDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "Principal_Investigator")]
        private IWebElement PrincipalInvestigator { get; set; }

        [FindsBy(How = How.Id, Using = "Key_Contact")]
        private IWebElement Key_Contact { get; set; }

        [FindsBy(How = How.Id, Using = "site-responsibility-radio-1")]
        private IWebElement Site_Responsible { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='rbtnRange']/following-sibling::div[1]/select[1]")]
        private IWebElement SiteTarget_RangeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialActivity']/tbody/tr[1]/td[2]/div/input[@class='control-field dirty-cop-applied']")]
        private IWebElement PreScreened { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialActivity']/tbody/tr[1]/td[3]/input[@class='control-field dirty-cop-applied']")]
        private IWebElement ScreenFailures { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialActivity']/tbody/tr[1]/td[4]/input[@class='control-field dirty-cop-applied']")]
        private IWebElement NewEnrollment { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialActivity']/tbody/tr[1]/td[5]/input[@class='control-field dirty-cop-applied']")]
        private IWebElement ActiveIntervention { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialActivity']/tbody/tr[1]/td[6]/input[@class='control-field dirty-cop-applied']")]
        private IWebElement CompletedIntervention { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialActivity']/tbody/tr[1]/td[7]/input[@class='control-field dirty-cop-applied']")]
        private IWebElement FollowUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialActivity']/tbody/tr[1]/td[8]/input[@class='control-field dirty-cop-applied']")]
        private IWebElement Discontinued { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveTrialDetails")]
        private IWebElement SaveTrialDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='esd-actions']/div[1]/a")]
        private IWebElement SaveAll { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='dropdown']/button")]
        private IWebElement ActionDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-small remove-button ']")]
        private IWebElement RemoveButton { get; set; }

        [FindsBy(How = How.Id, Using = "removeTrialConfirm")]
        private IWebElement ConfirmRemoveButton { get; set; }

        [FindsBy(How = How.Id, Using = "archiveTrialConfirm")]
        private IWebElement ConfirmArchiveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-small archive-button']")]
        private IWebElement ArchiveButton { get; set; }

        [FindsBy(How = How.Id, Using = "archiveTrialModalLabel")]
        private IWebElement ArchiveTrialPopUp { get; set; }

        [FindsBy(How = How.Id, Using = "removeTrialModalLabel")]
        private IWebElement RemoveTrialPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='removeTrialModal']/div[2]/p")]
        private IWebElement RemoveTrialMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialList']/tbody/tr/td[1]")]
        private IWebElement SearchTrialResult { get; set; }

        [FindsBy(How = How.Id, Using = "TrialAbandoned")]
        private IWebElement TrialAbandoned { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='siteTrialList']/tbody/tr[1]")]
        private IWebElement CreatedTrialRecord { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui-datepicker-calendar']")]
        private IWebElement Calender { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui-state-default ui-state-highlight']")]
        private IWebElement CalenderToday { get; set; }

        public void VerifyMySiteTrialsPageIsLoaded()
        {
            PageHelper.WaitForElement(Driver, MySiteTrialsTitle).Text.Should()
                .BeEquivalentTo("My Site Trials");
        }

        public void SelectAClinicalTrialUnit()
        {
            PageHelper.PickRandomValueFromDropdown(CTUDropdown);
        }

        public void VerifyReportPeriodDetails()
        {
            ReportPeriodHeading.Text.Should()
                .MatchRegex(
                    @"Report Period: (\d+)[-.\/](\d+)[-.\/](\d+) - (\d+)[-.\/](\d+)[-.\/](\d+) Submission Due Date: (\d+)[-.\/](\d+)[-.\/](\d+)");
        }

        public void SearchAndVerifyTheAddedTrial(string context)
        {
            MySiteTrialsSearch.SendKeys(context);
            CTUMySiteTrialResult_Acronym.Text.Should().Contain(context);
        }

        public void RemoveATrial(string contextTrialTitle)
        {
            MySiteTrialsSearch.Clear();
            MySiteTrialsSearch.SendKeys(contextTrialTitle);
            ActionDropDown.Click();
            RemoveButton.Click();
            PageHelper.WaitForElement(Driver, RemoveTrialPopUp);
            RemoveTrialMessage.Text.Should().BeEquivalentTo(ErrorMessages.RemoveTrial_MySiteTrial);
            ConfirmRemoveButton.Click();
        }

        public void SearchAndVerifyTheRemovedTrial(string contextTrialTitle)
        {
            MySiteTrialsSearch.Clear();
            MySiteTrialsSearch.SendKeys(contextTrialTitle);
            SearchTrialResult.Text.Should().BeEquivalentTo("No results to show");
        }

        public void SearchAndVerifyTheCreatedTrial(string context)
        {
            MySiteTrialsSearch.SendKeys(context);
            CTUMySiteTrialResult_Title.Text.Should().Contain(context);
        }

        public void AbandonTheCreatedTrial(string contextTrialTitle)
        {
            CreatedTrialRecord.Click();
            PageHelper.WaitForElement(Driver, SiteTarget_Exact_RadioButton);
            SiteTarget_Exact_RadioButton.Click();
            SiteTarget_Exact_Input.SendKeys("10");
            PageHelper.PickRandomValueFromDropdown(SiteTarget_ExactDropdown);
            FillInTrialDetails();
            PageHelper.WaitForElement(Driver, ActionDropDown);
            ActionDropDown.Click();
            ArchiveButton.Click();
            PageHelper.WaitForElement(Driver, ArchiveTrialPopUp);
            ConfirmArchiveButton.Click();
        }

        private void FillInTrialDetails()
        {
            PrincipalInvestigator.SendKeys("RgPrincipal");
            Key_Contact.SendKeys("RgKey");
            SaveTrialDetails.Click();
        }

        public void ArchiveTheAbandonedTrial(string contextTrialTitle)
        {
            Driver.Navigate().Refresh();
            MySiteTrialsSearch.Clear();
            MySiteTrialsSearch.SendKeys(contextTrialTitle);
            SearchTrialResult.Text.Should().BeEquivalentTo("No results to show");
        }
    }
}

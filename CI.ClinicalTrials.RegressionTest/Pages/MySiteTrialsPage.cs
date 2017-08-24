using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        [FindsBy(How = How.Id, Using = "regRGONotApplicable")]
        private IWebElement RGONotApplicable { get; set; }

        [FindsBy(How = How.Id, Using = "RecruitmentOpen")]
        private IWebElement RecruitmentOpen { get; set; }

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

        [FindsBy(How = How.Id, Using = "regPreScreened")]
        private IWebElement PreScreened { get; set; }

        [FindsBy(How = How.Id, Using = "regScreenFailures")]
        private IWebElement ScreenFailures { get; set; }

        [FindsBy(How = How.Id, Using = "regNewEnrollment")]
        private IWebElement NewEnrollment { get; set; }

        [FindsBy(How = How.Id, Using = "regActiveIntervention")]
        private IWebElement ActiveIntervention { get; set; }

        [FindsBy(How = How.Id, Using = "regCompletedIntervention")]
        private IWebElement CompletedIntervention { get; set; }

        [FindsBy(How = How.Id, Using = "regFollowUp")]
        private IWebElement FollowUp { get; set; }

        [FindsBy(How = How.Id, Using = "regDiscontinued")]
        private IWebElement Discontinued { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveTrialDetails")]
        private IWebElement SaveTrialDetails { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveAll")]
        private IWebElement SaveAll { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='mysite-table-filters']/button[6]")]
        private IWebElement FilterArchived { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@class=' ui-datepicker-days-cell-over  ui-datepicker-today']")]
        private IWebElement CalenderToday { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-info']/h4")]
        private IWebElement SignOffTrialDataMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='error-messages']")]
        private IWebElement EmptyTrialDetailsMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-info']/h4")]
        private IWebElement EmptyParticipatDetailsErrorMessage { get; set; }

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
            Driver.Navigate().Refresh();
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
            FIllInMandatoryTrialDates();
            TrialAbandoned.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            CalenderToday.Click();
            FillInTrialDetailsAndActivity();
            SaveTrialDetails.Click();
            Thread.Sleep(TimeSpan.FromSeconds(8));
            PageHelper.WaitForElement(Driver, ActionDropDown);
            ActionDropDown.Click();
            ArchiveButton.Click();
            PageHelper.WaitForElement(Driver, ArchiveTrialPopUp);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            ConfirmArchiveButton.Click();
        }

        private void FIllInMandatoryTrialDates()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            SiteTarget_Exact_RadioButton.Click();
            SiteTarget_Exact_Input.SendKeys("10");
            PageHelper.PickRandomValueFromDropdown(SiteTarget_ExactDropdown);
        }

        private void FillInTrialDetailsAndActivity()
        {
            PrincipalInvestigator.SendKeys("RgPrincipal");
            Key_Contact.SendKeys("RgKey");
            Site_Responsible.Click();
        }

        public void ArchiveTheAbandonedTrial(string contextTrialTitle)
        {
            Driver.Navigate().Refresh();
            MySiteTrialsSearch.Clear();
            MySiteTrialsSearch.SendKeys(contextTrialTitle);
            SearchTrialResult.Text.Should().BeEquivalentTo("No results to show");
        }

        public void ApplyFilterAndVerifyTrialData(string filter, string contextTrialTitle)
        {
            Driver.Navigate().Refresh();
            if (filter.ToLower().Equals("archived"))
            {
                FilterArchived.Click();
            }
            MySiteTrialsSearch.Clear();
            MySiteTrialsSearch.SendKeys(contextTrialTitle);
            CTUMySiteTrialResult_Title.Text.Should().BeEquivalentTo(contextTrialTitle);
        }

        public void FillinTrialDataAndSave(string contextTrialTitle)
        {
            CreatedTrialRecord.Click();
            FillInTrialDateDetails();
            FillInTrialDetailsAndActivity();
            FillInCancerParticipantsData();
            SaveAll.Click();
        }

        private void FillInCancerParticipantsData()
        {
            PreScreened.SendKeys("5");
            ScreenFailures.SendKeys("3");
            NewEnrollment.SendKeys("4");
            ActiveIntervention.SendKeys("2");
            CompletedIntervention.SendKeys("1");
            FollowUp.SendKeys("2");
            Discontinued.SendKeys("1");
        }

        private void FillInTrialDateDetails()
        {
            FIllInMandatoryTrialDates();
            RGONotApplicable.Click();
            RecruitmentOpen.Click();
            PageHelper.WaitForElement(Driver, CalenderToday).Click();
        }

        public void SearchAndOpenTheSignedOffTrial(string contextTrialTitle)
        {
            PageHelper.WaitForElement(Driver, MySiteTrialsSearch);
            MySiteTrialsSearch.SendKeys(contextTrialTitle);
            SearchTrialResult.Click();
        }

        public void VerifyTheTrialDataIsDisabled()
        {
            PageHelper.WaitForElement(Driver, SignOffTrialDataMessage).Text.Should().BeEquivalentTo(ErrorMessages.SignedOffTrialData);
        }

        public void SaveEmptyTrialDetails()
        {
            CreatedTrialRecord.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            PageHelper.WaitForElement(Driver, SaveTrialDetails);
            SaveTrialDetails.Click();
        }

        public void VerifyTrialDetailMandatoryErrorMessages()
        {
            PageHelper.WaitForElement(Driver, EmptyTrialDetailsMessage).Text.Should()
                .BeEquivalentTo(ErrorMessages.EmptyTrialDetailMessage);
        }

        public void SaveEmptyParticipantDetails()
        {
            PageHelper.WaitForElement(Driver, SaveAll).Click();
        }

        public void VerifyParticipantMandatoryErrorMessages()
        {
            PageHelper.WaitForElement(Driver, EmptyTrialDetailsMessage).Text.Should()
                .BeEquivalentTo(ErrorMessages.EmptyParticipantErrorMessage);
        }

        public void FillInTrialDateAndActivityDetails()
        {
            FillInTrialDateDetails();
            FillInTrialDetailsAndActivity();
        }
    }
}

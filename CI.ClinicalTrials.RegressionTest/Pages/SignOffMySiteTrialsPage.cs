using System;
using System.Threading;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class SignOffMySiteTrialsPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "regExistingFTE")]
        private IWebElement ExistingFTE { get; set; }

        [FindsBy(How = How.Id, Using = "regNewFTE")]
        private IWebElement NewFTE { get; set; }

        [FindsBy(How = How.Id, Using = "txtFTE")]
        private IWebElement FTEInput { get; set; }

        [FindsBy(How = How.Id, Using = "chkSignoff")]
        private IWebElement SignOffCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "btnSignOff")]
        private IWebElement Submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='span3 complete-sign-off-view']")]
        private IWebElement SignOffDisclaimer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='signoffTrialList_filter']/label/input")]
        private IWebElement SignOffTrialSummarySearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='signoffTrialList']/tbody/tr[1]/td[3]")]
        private IWebElement SignOffTrialSummaryResult_Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='signoffHistoryList_filter']/label/input")]
        private IWebElement SignOffTrialHistorySearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='signoffHistoryList']/tbody/tr[1]/td[2]")]
        private IWebElement SignOffTrialHistoryResult_Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='paginate_button current']")]
        private IWebElement Load_DataTable { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[@class='trial-details-edit']/td/div[6]/div[1]/p/span/label")]
        private IWebElement TrialSummary_ScreenFailure { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[@class='trial-details-edit']/td/div[6]/div[2]/p/span/label")]
        private IWebElement TrialSummary_ActiveOnTrial { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[@class='trial-details-edit']/td/div[6]/div[3]/p/span/label")]
        private IWebElement TrialSummary_PatientFollowUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[@class='trial-details-edit']/td/div[6]/div[4]/p/span/label")]
        private IWebElement TrialSummary_PatientsDiscontinued { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[@class='trial-details-edit']/td/div[5]/div[2]/p/span/label")]
        private IWebElement TrialSummary_CurrentEnrollment { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[@class='trial-details-edit']/td/div[4]/div[3]/p/span/label")]
        private IWebElement TrialSummary_RecruitmentTarget { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[@class='trial-details-edit']/td/div[3]/div[3]/p/span/label")]
        private IWebElement TrialSummary_RecruitmentOpen { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='signoffTrialList']/tbody/tr[1]/td[2]")]
        private IWebElement SignOffTrialSummaryResult_ReportPeriod { get; set; }

        /// <summary>
        /// Search and sign off trials.
        /// </summary>
        /// <param name="contextTrialTitle">The context trial title.</param>
        /// <returns>System.String.</returns>
        public string SearchAndSignOffTrials(string contextTrialTitle)
        {
            SignOffTrialSummarySearch.SendKeys(contextTrialTitle);
            SignOffTrialSummaryResult_Title.Text.Should().BeEquivalentTo(contextTrialTitle);
            var reportPeriod = SignOffTrialSummaryResult_ReportPeriod.Text;
            NewFTE.Click();
            FTEInput.SendKeys("2");
            SignOffCheckBox.Click();
            Submit.Click();
            return reportPeriod;
        }

        /// <summary>
        /// Verifies the signed off trials.
        /// </summary>
        /// <param name="contextTrialTitle">The context trial title.</param>
        public void VerifySignedOffTrials(string contextTrialTitle)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            SignOffTrialHistorySearch.SendKeys(contextTrialTitle);
            SignOffTrialHistoryResult_Title.Text.Should().BeEquivalentTo(contextTrialTitle);
        }

        /// <summary>
        /// Verifies the trial summary details.
        /// </summary>
        /// <param name="contextTrialTitle">The context trial title.</param>
        public void VerifyTrialSummaryDetails(string contextTrialTitle)
        {
            PageHelper.WaitForElement(Driver, SignOffTrialSummarySearch);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var today = DateTime.Now.ToString("dd/MM/yyyy");
            SignOffTrialSummarySearch.SendKeys(contextTrialTitle);
            SignOffTrialSummaryResult_Title.Text.Should().BeEquivalentTo(contextTrialTitle);
            SignOffTrialSummaryResult_Title.Click();
            PageHelper.WaitForElement(Driver, TrialSummary_RecruitmentOpen);
            TrialSummary_RecruitmentOpen.Text.Should().BeEquivalentTo(today);
            TrialSummary_RecruitmentTarget.Text.Should().BeEquivalentTo("10");
            TrialSummary_CurrentEnrollment.Text.Should().BeEquivalentTo("4");
            TrialSummary_ScreenFailure.Text.Should().BeEquivalentTo("3");
            TrialSummary_ActiveOnTrial.Text.Should().BeEquivalentTo("2");
            TrialSummary_PatientFollowUp.Text.Should().BeEquivalentTo("2");
            TrialSummary_PatientsDiscontinued.Text.Should().BeEquivalentTo("1");
        }

        /// <summary>
        /// Determines whether is sign off option displayed.
        /// </summary>
        /// <returns><c>true</c> if [is sign off option displayed]; otherwise, <c>false</c>.</returns>
        public bool IsSignOffOptionDisplayed()
        {
            return SignOffDisclaimer.Text.Contains("Report Period Sign-Off Disclaimer");
        }
    }
}

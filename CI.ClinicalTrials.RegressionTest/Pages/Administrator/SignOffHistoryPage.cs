using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    class SignOffHistoryPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "ReportPeriods")]
        private IWebElement SignOffReportPeriod { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='btn btn-primary']")]
        private IWebElement RunReport { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement SignOffHistorySearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTableSignOff']/tbody/tr[1]/td[3]")]
        private IWebElement SignOffHistoryResult_SubmittedBy { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTableSignOff']/tbody/tr[1]/td[4]")]
        private IWebElement SignOffHistoryResult_SignedOn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='paginate_button current']")]
        private IWebElement Load_DataTable { get; set; }

        /// <summary>
        /// Runs the report for current report period.
        /// </summary>
        /// <param name="contextReportPeriod">The context report period.</param>
        public void RunReportForCurrentReportPeriod(string contextReportPeriod)
        {
            PageHelper.SelectValueFromDropdown(SignOffReportPeriod, contextReportPeriod);
            RunReport.Click();
        }

        /// <summary>
        /// Search and verify sign off history details.
        /// </summary>
        public void SearchAndVerifySignOffHistoryDetails()
        {
            PageHelper.WaitForElement(Driver, SignOffHistorySearch).SendKeys("RegClinicalTrialUnit02");
            PageHelper.WaitForElement(Driver, Load_DataTable);
            SignOffHistoryResult_SubmittedBy.Text.Should().BeEquivalentTo("Automated User");
            SignOffHistoryResult_SignedOn.Text.Should()
                .MatchRegex("[0-3][0-9]/[0-1][0-9]/[0-9][0-9][0-9][0-9] \\d{1,2}:[0-5][0-9]:[0-5][0-9] [paPA][Mm]");

        }
    }
}

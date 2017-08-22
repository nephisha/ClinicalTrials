using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        public void SearchAndSignOffTrials(string contextTrialTitle)
        {
            SignOffTrialSummarySearch.SendKeys(contextTrialTitle);
            SignOffTrialSummaryResult_Title.Text.Should().BeEquivalentTo(contextTrialTitle);
            NewFTE.Click();
            FTEInput.SendKeys("2");
            SignOffCheckBox.Click();
            Submit.Click();
        }

        public void VerifySignedOffTrials(string contextTrialTitle)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            SignOffTrialHistorySearch.SendKeys(contextTrialTitle);
            SignOffTrialHistoryResult_Title.Text.Should().BeEquivalentTo(contextTrialTitle);
        }

        public void VerifyTrialSummaryDetails(string contextTrialTitle)
        {
            
        }
    }
}

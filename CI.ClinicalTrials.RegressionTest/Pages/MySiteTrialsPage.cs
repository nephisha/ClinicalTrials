using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

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

        [FindsBy(How = How.XPath, Using = "//label[@for='rbtnExact']/following-sibling::div[1]/select[1]")]
        private IWebElement SiteTarget_ExactDropdown { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//div[@class='esd-actions']/div[2]/a")]
        private IWebElement SaveTrialDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='esd-actions']/div[1]/a")]
        private IWebElement SaveAll { get; set; }

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

        public void SearchAndVerifyTheAddedTrial()
        {
            var acronymSearch = MasterTrialListSearchPage.TrialAcronym;
            MySiteTrialsSearch.SendKeys(acronymSearch);
            CTUMySiteTrialResult_Acronym.Text.Should().BeEquivalentTo(acronymSearch);
        }
    }
}

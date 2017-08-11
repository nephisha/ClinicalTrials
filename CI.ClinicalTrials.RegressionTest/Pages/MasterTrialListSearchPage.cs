using System.Collections.Generic;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class MasterTrialListSearchPage : PageBase
    {
        [FindsBy(How = How.XPath, Using = "//form[@id='searchForm']/fieldset/legend")]
        private IWebElement MasterTrialListSearch { get; set; }

        [FindsBy(How = How.Id, Using = "Query")]
        private IWebElement Query { get; set; }

        [FindsBy(How = How.Name, Using = "submitCommand")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[6]")]
        private IWebElement SearchTrialResult_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='paginate_button current']")]
        private IWebElement Load_DataTable { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[10]")]
        private IWebElement SearchTrialResult_VerificationStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini editTrialBtn']")]
        private IWebElement EditTrials { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini btn-join-trial']")]
        private IWebElement AddToMyTrialsList { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-mini btn-danger removeTrial dirty-cop-applied']")]
        private IWebElement RemoveFromMasterList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='TumourGroupIDs_chosen']/div//li")]
        private IList<IWebElement> TumourGroups { get; set; }

        public void VerifyMasterTrialListSearchPageIsLoaded()
        {
            PageHelper.WaitForElement(Driver, MasterTrialListSearch).Text.Should()
                .BeEquivalentTo("Master Trial List Search");
        }

        public void SearchAndVerifyTheCreatedTrial(string title)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            SearchForCreatedTrial(title);
            PageHelper.WaitForElement(Driver, Load_DataTable);
            PageHelper.WaitForElement(Driver, SearchTrialResult_Name).Text.Should().Contain(title);
        }

        private void SearchForCreatedTrial(string text)
        {
            Query.SendKeys("Title" + text);
            SearchButton.Click();
        }
    }
}

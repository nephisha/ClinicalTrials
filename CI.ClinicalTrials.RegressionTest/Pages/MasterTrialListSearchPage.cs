using System;
using System.Collections.Generic;
using System.Threading;
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
        private const string SearchCriteria = "NickRegTest";
        
        [FindsBy(How = How.XPath, Using = "//form[@id='searchForm']/fieldset/legend")]
        private IWebElement MasterTrialListSearch { get; set; }

        [FindsBy(How = How.Id, Using = "Query")]
        private IWebElement Query { get; set; }

        [FindsBy(How = How.Name, Using = "submitCommand")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "SponsorID")]
        private IWebElement Sponsor { get; set; }

        [FindsBy(How = How.Id, Using = "CTUID")]
        private IWebElement CTU { get; set; }

        [FindsBy(How = How.Id, Using = "TumourGroupIDs_chosen")]
        private IWebElement TumourGroup { get; set; }

        [FindsBy(How = How.Id, Using = "TrialClassification")]
        private IWebElement TrialClassification { get; set; }

        [FindsBy(How = How.Id, Using = "TrialVerification")]
        private IWebElement TrialVerification { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='TumourGroupIDs_chosen']/div/ul/li")]
        private IList<IWebElement> TumourGroupResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[6]")]
        private IWebElement AdminSearchTrialResult_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[5]")]
        private IWebElement CTUSearchTrialResult_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[2]")]
        private IWebElement CTUSearchTrialResult_Sponsor { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[7]")]
        private IWebElement CTUSearchTrialResult_TumourGroup { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='paginate_button current']")]
        private IWebElement Load_DataTable { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[3]/span")]
        private IWebElement CTUSearchTrialResult_Acronym { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[12]")]
        private IWebElement AdminSearchTrialResult_ClassificationStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[11]")]
        private IWebElement AdminSearchTrialResult_VerificationStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini editTrialBtn']")]
        private IWebElement EditTrials { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini btn-join-trial']")]
        private IWebElement AddToMyTrialsList { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-mini btn-danger removeTrial dirty-cop-applied']")]
        private IWebElement RemoveFromMasterList { get; set; }


        public void VerifyMasterTrialListSearchPageIsLoaded()
        {
            PageHelper.WaitForElement(Driver, MasterTrialListSearch).Text.Should()
                .BeEquivalentTo("Master Trial List Search");
        }

        public void SearchAndVerifyTheCreatedTrialByAdmin(string title)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            SearchForCreatedTrial(title);
            PageHelper.WaitForElement(Driver, Load_DataTable);
            PageHelper.WaitForElement(Driver, AdminSearchTrialResult_Name).Text.Should().Contain(title);
        }

        public void SearchAndVerifyTheCreatedTrialByCTUUser(string title)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            SearchForCreatedTrial(title);

            try
            {
                PageHelper.WaitForElement(Driver, Load_DataTable);
                PageHelper.WaitForElement(Driver, CTUSearchTrialResult_Name).Text.Should().Contain(title);
            }
            catch (Exception e)
            {
                var pageSource = Driver.PageSource;
                Console.WriteLine(e);
                Console.WriteLine(pageSource);
                SearchForCreatedTrial(title);
                PageHelper.WaitForElement(Driver, CTUSearchTrialResult_Name).Text.Should().Contain(title);
            }
            
        }

        private void SearchForCreatedTrial(string text)
        {
            Query.Clear();
            Query.SendKeys("Title" + text);
            SearchButton.Click();
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
        }

        public void SearchByQuery()
        {
            Query.SendKeys(SearchCriteria);
            SearchButton.Click();
        }

        public void VerifySearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            Query.GetAttribute("value").Should().BeEquivalentTo(SearchCriteria);
            CTUSearchTrialResult_Acronym.Text.Should().Contain(SearchCriteria);
        }

        public void SearchBySponsor()
        {
            PageHelper.SelectValueFromDropdown(Sponsor, "Abbott");
            SearchButton.Click();
        }

        public void VerifySponsorSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            CTUSearchTrialResult_Sponsor.Text.Should().BeEquivalentTo("Abbott");
        }

        public void SearchByCTU()
        {
            PageHelper.SelectValueFromDropdown(CTU, "Bankstown Hospital");
            SearchButton.Click();
        }

        public void VerifyCTUSearchResults()
        {
            
        }

        public void SearchByTumourGroups()
        {
            TumourGroup.Click();
            PageHelper.SelectValueFromDropList(TumourGroupResult, "Brain");
            SearchButton.Click();
        }

        public void VerifyTumourGroupResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            CTUSearchTrialResult_TumourGroup.Text.Should().BeEquivalentTo("Brain");
        }

        public void SearchByTrialClassification()
        {
            PageHelper.SelectValueFromDropdown(TrialClassification, "Portfolio");
            SearchButton.Click();
        }

        public void VerifyClassificationSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_ClassificationStatus.Text.Should().BeEquivalentTo("Portfolio");
        }

        public void SearchByVerificationStatus()
        {
            PageHelper.SelectValueFromDropdown(TrialVerification, "Verified");
            SearchButton.Click();
        }

        public void VerifyVerificationStatusSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Verified");
        }
    }
}
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    public class SponsorPage : PageBase
    {
        private string sName;

        [FindsBy(How = How.Id, Using = "regCreateNewSponsor")]
        private IWebElement CreateNewSponsor { get; set; }

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "Description")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.Id, Using = "SponsorCategory")]
        private IWebElement SponsorCategory { get; set; }

        [FindsBy(How = How.Id, Using = "Deprecated")]
        private IWebElement Deprecated { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveSponsorButton")]
        private IWebElement CreateSponsorButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn")]
        private IWebElement BackToListButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement SponsorSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[2]")]
        private IWebElement SponsorSearchResult_Name { get; set; }

        [FindsBy(How = How.Id, Using = "regEditSponsor")]
        private IWebElement EditSponsor { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveSponsorButton")]
        private IWebElement SaveSponsorButton { get; set; }

        public void ClickonCreateNewSponsor()
        {
            CreateNewSponsor.Click();
        }

        public void FillInSponsorDetailsAndClickCreate()
        {
            sName = "Reg_Sponsor" + PageHelper.RandomNumber(4);
            Name.SendKeys(sName);
            Description.SendKeys("Sponsor Created by Regression Tests");
            PageHelper.PickRandomValueFromDropdown(SponsorCategory);
            CreateSponsorButton.Click();
            BackToListButton.Click();
        }

        public void SearchAndVerifyTheCreatedSponsor()
        {
            SponsorSearch.SendKeys(sName);
            SponsorSearchResult_Name.Text.Should().BeEquivalentTo(sName);
        }
    }
}

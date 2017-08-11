using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    public class LHDPage : PageBase
    {
        private string lName;

        [FindsBy(How = How.Id, Using = "regCreateNewLHD")]
        private IWebElement CreateNewLHD { get; set; }

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "Acronym")]
        private IWebElement Acronym { get; set; }

        [FindsBy(How = How.Id, Using = "CoreFunding")]
        private IWebElement PeriodicCoreFunding { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement LHDSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn")]
        private IWebElement BackToListButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "sorting_1")]
        private IWebElement LHDSearchResult_Name { get; set; }

        [FindsBy(How = How.Id, Using = "regEditLHD")]
        private IWebElement EditLHD { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveLHDButton")]
        private IWebElement SaveLHDButton { get; set; }

        public void ClickonCreateNewLHD()
        {
            CreateNewLHD.Click();
        }

        public void FillInLHDDetailsAndClickCreate()
        {
            lName = "RegTestLHD" + PageHelper.RandomNumber(4);
            Name.SendKeys(lName);
            Acronym.SendKeys("RGT"+ PageHelper.RandomNumber(2));
            PeriodicCoreFunding.SendKeys("20000");
            SaveLHDButton.Click();
            BackToListButton.Click();
        }

        public void SearchAndVerifyTheCreatedLHD()
        {
            LHDSearch.SendKeys(lName);
            LHDSearchResult_Name.Text.Should().BeEquivalentTo(lName);
        }
    }
}

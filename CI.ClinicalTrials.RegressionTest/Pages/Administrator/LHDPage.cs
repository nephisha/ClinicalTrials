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

        /// <summary>
        /// Click to create new LHD.
        /// </summary>
        public void ClickonCreateNewLHD()
        {
            CreateNewLHD.Click();
        }

        /// <summary>
        /// Fills in LHD details and click create.
        /// </summary>
        public void FillInLHDDetailsAndClickCreate()
        {
            lName = "RegTestLHD" + PageHelper.RandomNumber(4);
            Name.SendKeys(lName);
            Acronym.SendKeys("RGT"+ PageHelper.RandomNumber(4));
            PeriodicCoreFunding.SendKeys("20000");
            SaveLHDButton.Click();
            BackToListButton.Click();
        }

        /// <summary>
        /// Searches and verify the created LHD.
        /// </summary>
        public void SearchAndVerifyTheCreatedLHD()
        {
            LHDSearch.SendKeys(lName);
            LHDSearchResult_Name.Text.Should().BeEquivalentTo(lName);
        }

        /// <summary>
        /// Searches and edit the LHD.
        /// </summary>
        public void SearchAndEditTheLHD()
        {
            PageHelper.WaitForElement(Driver, LHDSearch).Click();
            LHDSearch.SendKeys(lName);
            PageHelper.WaitForElement(Driver, EditLHD).Click();
            Name.Click();
            Name.Clear();
            Name.SendKeys("Edited"+lName);
            SaveLHDButton.Click();
            BackToListButton.Click();
        }

        /// <summary>
        /// Searches and verify the edited LHD.
        /// </summary>
        public void SearchAndVerifyTheEditedLHD()
        {
            LHDSearch.SendKeys("Edited" + lName);
            LHDSearchResult_Name.Text.Should().BeEquivalentTo("Edited" + lName);
        }
    }
}

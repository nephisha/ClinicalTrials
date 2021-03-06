﻿using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class HomePage : PageBase
    {
        [FindsBy(How = How.Name, Using = "Query")]
        private IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.Id, Using = "legend-sites")]
        private IWebElement Hospital { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='days-left-panel']/div")]
        private IWebElement NumberOfDaysLeft { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='last-updated-panel']/div")]
        private IWebElement LastUpdated { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='trial-category']/div/div[1]/div/child::*[1]")]
        private IWebElement TrialCategory { get; set; }

        public void SelectAHospital(string hospital)
        {
            var select = new SelectElement(Hospital);
            select.SelectByText(hospital);
        }

        /// <summary>
        /// Searches using the search box at the top navigation menu.
        /// </summary>
        public void SearchByTopNavigationMenu()
        {
            Driver.Manage().Window.Maximize();
            PageHelper.WaitForElement(Driver, SearchIcon);
            SearchIcon.Click();
            SearchIcon.SendKeys("NickRegTest");
            SearchIcon.SendKeys(Keys.Enter);
        }

        /// <summary>
        /// Verifies the days left.
        /// </summary>
        public void VerifyDaysLeftPanel()
        {
            NumberOfDaysLeft.Text.Should().StartWithEquivalent("Number of days left in");
        }

        /// <summary>
        /// Verifies the last updated by details.
        /// </summary>
        public void VerifyLastUpdatedPanel()
        {
            LastUpdated.Text.Should().StartWithEquivalent("Last updated by");
        }

        public string VerifyTrialCategoryIsDisplayed()
        {
            var category = TrialCategory.GetAttribute("textContent");
            return category;
        }
    }
}

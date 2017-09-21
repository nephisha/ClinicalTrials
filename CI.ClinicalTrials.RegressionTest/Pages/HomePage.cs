using CI.ClinicalTrials.RegressionTest.Base;
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
            SearchIcon.Click();
            SearchIcon.SendKeys("NickRegTest");
            SearchIcon.SendKeys(Keys.Enter);
        }
    }
}

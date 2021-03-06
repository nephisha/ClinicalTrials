﻿using System.Configuration;
using CI.ClinicalTrials.RegressionTest.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class LoginPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log On']")]
        private IWebElement Submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='validation-summary-errors alert alert-error']/span")]
        private IWebElement LoginError { get; set; }

        /// <summary>
        /// Launches the browser with the given URL.
        /// </summary>
        public void LaunchTheApplication()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["RegressionTest.URL"]);
        }

        /// <summary>
        /// Logins to application.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="pwd">The password.</param>
        public void LoginToApplication(string user, string pwd)
        {
            UserName.SendKeys(user);
            Password.SendKeys(pwd);
            Submit.Click();
        }

        /// <summary>
        /// Gets the login validation error.
        /// </summary>
        /// <value>The login validation error.</value>
        public string LoginValidationError => LoginError.Text;
    }
}

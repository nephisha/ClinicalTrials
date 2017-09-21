using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CI.ClinicalTrials.RegressionTest.Base
{
    /// <summary>
    /// In this Base Driver class, the creation of Selenium WebDriver happens
    /// </summary>
    public class DriverBase
    {
        /// <summary>
        /// Instance of webdriver used to control the browser session
        /// </summary>
        /// <value>The driver.</value>
        protected static IWebDriver Driver { get; set; }

        /// <summary>
        /// Creates an instance of the default ChromeDriver.
        /// </summary>
        /// <returns>IWebDriver.</returns>
        public static IWebDriver GetDefaultDriver()
        {
            Driver = new ChromeDriver();
            //Driver = new ChromeDriver(@"C:\Drivers");
            new ChromeOptions().AddArguments("--no-sandbox");
            Driver.Manage().Window.Maximize();
            //Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return Driver;
        }
    }
}

using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

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
            var options = new ChromeOptions();
            options.AddArguments("--no-sandbox");
            if (bool.Parse(ConfigurationManager.AppSettings["RegressionTest.HeadlessChrome"]))
                options.AddArguments("--headless", "--disable-gpu");
            Driver = new ChromeDriver(options);

            Driver.Manage().Window.Maximize();
            //Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return Driver;
        }
    }
}

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CI.ClinicalTrials.RegressionTest.Base
{
    public class DriverBase
    {
        protected static IWebDriver Driver { get; set; }

        public static IWebDriver GetDefaultDriver()
        {
            Driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--no-sandbox");
            //options.AddArgument("--start-maximized");
            Driver.Manage().Window.Maximize();
            //Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return Driver;
        }
    }
}

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
            //Driver = new ChromeDriver(@"C:\Drivers");
            new ChromeOptions().AddArguments("--no-sandbox");
            //Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return Driver;
        }
    }
}

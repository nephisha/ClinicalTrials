using System;
using System.Configuration;
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
            /* Adding Chrome Logs */

            //DesiredCapabilities cap = DesiredCapabilities.Chrome();
            //ChromePerformanceLoggingPreferences perfLogPrefs = new ChromePerformanceLoggingPreferences()
            //{
            //    IsCollectingTimelineEvents = true,
            //    IsCollectingPageEvents = true
            //};
            //perfLogPrefs.AddTracingCategories(new string[] { "devtools.timeline" });
            //options.PerformanceLoggingPreferences = perfLogPrefs;
            //options.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
            //options.SetLoggingPreference("performance", LogLevel.All);

            //var service = ChromeDriverService.CreateDefaultService();
            //service.LogPath = "chromedriver.log";
            //service.EnableVerboseLogging = true;

            /* Setting Up Chrome Driver */

            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArguments("--no-sandbox");
            if (bool.Parse(ConfigurationManager.AppSettings["RegressionTest.HeadlessChrome"]))
                options.AddArguments("--headless", "--disable-gpu");
            Driver = new ChromeDriver(options);


            /* Setting Up Phantom Ghost Driver */
            //Driver = new PhantomJSDriver();

            //Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return Driver;

        }
    }
}

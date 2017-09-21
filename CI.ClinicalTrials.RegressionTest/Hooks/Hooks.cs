using System;
using System.Diagnostics;
using CI.ClinicalTrials.RegressionTest.Base;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver driver;

        /// <summary>
        /// Runs before the scenario.
        /// </summary>
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = DriverBase.GetDefaultDriver();
        }

        /// <summary>
        /// Runs after the scenario.
        /// </summary>
        [AfterScenario]
        public void AfterScenario()
        {
            ScenarioTearDown();
            driver.Quit();
        }

        /// <summary>
        /// Runs after every feature
        /// </summary>
        [AfterFeature]
        public static void AfterAll()
        {
            var chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }

        /// <summary>
        /// Gets executed when a test fails
        /// </summary>
        [TearDown]
        public virtual void ScenarioTearDown()
        {
            try
            {
                if (Equals(TestContext.CurrentContext.Result.Outcome, ResultState.Success)) return;
                const string path = @"C:\Reports\Screenshot\";
                var timestamp = DateTime.Now.ToString("MM-dd-hh-mm-ss");
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path + timestamp+".jpeg", ScreenshotImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                driver.SwitchTo().Alert().Accept();
                const string path = @"C:\Reports\Screenshot\";
                var timestamp = DateTime.Now.ToString("MM-dd-hh-mm-ss");
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path + timestamp + ".jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(@"Exception while taking screen shot: {0}", e);
            }
        }
    }
}

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
        private IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = DriverBase.GetDefaultDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            ScenarioTearDown();
            _driver.Quit();
        }

        [AfterFeature]
        public static void AfterAll()
        {
            var chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }

        [TearDown]
        public virtual void ScenarioTearDown()
        {
            try
            {
                if (!Equals(TestContext.CurrentContext.Result.Outcome, ResultState.Success))
                {
                    const string path = @"C:\Reports\Screenshot\";
                    var timestamp = DateTime.Now.ToString("MM-dd-hh-mm-ss");
                    var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                    screenshot.SaveAsFile(path + timestamp+".jpeg", ScreenshotImageFormat.Jpeg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while taking screen shot: {0}", e);
            }
        }
    }
}

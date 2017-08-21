using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CI.ClinicalTrials.RegressionTest.Pages;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public sealed class LogoffSteps
    {
        private readonly MenuPage menuPage = new MenuPage();

        [Then(@"I LogOff the Clinical Trial Application")]
        public void ThenILogOffTheClinicalTrialApplication()
        {
            menuPage.LogOffTheApplication();
        }
    }
}

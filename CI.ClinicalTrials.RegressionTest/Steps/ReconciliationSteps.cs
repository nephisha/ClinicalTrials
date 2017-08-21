using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CI.ClinicalTrials.RegressionTest.Pages;
using CI.ClinicalTrials.RegressionTest.Pages.Administrator;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public sealed class ReconciliationSteps
    {
        private readonly MenuPage menuPage = new MenuPage();
        private readonly ReconciliationPage reconciliationPage = new ReconciliationPage();

        [Given(@"I should see the signed off trial for reconciliation")]
        public void GivenIShouldSeeTheSignedOffTrialForReconciliation()
        {
            menuPage.SelectReconciliationFromToggleMenu();
            reconciliationPage.SelectTheReconciliationLHD();

        }

        [When(@"I approve and finalize the trial")]
        public void WhenIApproveAndFinalizeTheTrial()
        {
            reconciliationPage.ApproveSignedOffTrials();
            reconciliationPage.FinalizeApprovedTrials();
        }

        [Then(@"I see the trial finalized successfully")]
        public void ThenISeeTheTrialFinalizedSuccessfully()
        {
            
        }
    }
}

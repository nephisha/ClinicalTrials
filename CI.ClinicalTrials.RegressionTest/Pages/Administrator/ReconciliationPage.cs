﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    public class ReconciliationPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "legend-lhds")]
        private IWebElement ReconcileLHD { get; set; }

        [FindsBy(How = How.Id, Using = "btn-approve")]
        private IWebElement ApproveButton { get; set; }

        [FindsBy(How = How.Id, Using = "btn-finalise")]
        private IWebElement FinalizeButton { get; set; }

        public void SelectTheReconciliationLHD()
        {
            PageHelper.SelectValueFromDropdown(ReconcileLHD, "RegressionLHD");
        }

        public void ApproveSignedOffTrials()
        {
            PageHelper.WaitForElement(Driver, ApproveButton).Click();
        }

        public void FinalizeApprovedTrials()
        {
            PageHelper.WaitForElement(Driver, FinalizeButton).Click();
        }
    }
}
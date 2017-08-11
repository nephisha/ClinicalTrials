using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CI.ClinicalTrials.RegressionTest.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class SignOffMySiteTrialsPage : PageBase
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='rdFTE' and @value=0]")]
        private IWebElement ExistingFTE { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='rdFTE' and @value=1]")]
        private IWebElement NewFTE { get; set; }
    }
}

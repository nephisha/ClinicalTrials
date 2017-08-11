using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    class ExtensionsPage : PageBase
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini btn-primary']")]
        private IWebElement CreateNewReportReriodExtension { get; set; }

        [FindsBy(How = How.Id, Using = "Extension_CTUId")]
        private IWebElement Site { get; set; }

        [FindsBy(How = How.Id, Using = "Extension_ReportingPeriodId")]
        private IWebElement Extension_ReportingPeriod { get; set; }

        [FindsBy(How = How.Id, Using = "Extension_ExtensionDate")]
        private IWebElement Extension_Date { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        private IWebElement CreateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[@class='sorting'][4]")]
        private IWebElement CreatedByAscSort { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[@class='sorting_asc']")]
        private IWebElement CreatedByDescSort { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[3]")]
        private IWebElement ExtensionResult_Date { get; set; }

        public void ClickonCreateNewReportPeriodExtension()
        {
            CreateNewReportReriodExtension.Click();
        }
        
        public void FillInExtensionDetailsAndClickCreate()
        {
            PageHelper.SelectValueFromDropdown(Site, "Bankstown Hospital");
            PageHelper.SelectValueFromDropdown(Extension_ReportingPeriod, "ReportPeriod Q3 2017");
            Driver.ExecuteJavaScript(@"$('#Extension_ExtensionDate').val('01/01/2018')");
            CreateButton.Click();
        }

        public void SearchAndVerifyTheCreatedExtension()
        {
            CreatedByAscSort.Click();
            CreatedByDescSort.Click();
            ExtensionResult_Date.Text.Should().BeEquivalentTo("01/01/2018");
        }
    }
}

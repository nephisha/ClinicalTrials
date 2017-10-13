using System;
using System.Threading;
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
        [FindsBy(How = How.Id, Using = "regCreateNewReportReriodExtension")]
        private IWebElement CreateNewReportReriodExtension { get; set; }

        [FindsBy(How = How.Id, Using = "Extension_CTUId")]
        private IWebElement Site { get; set; }

        [FindsBy(How = How.Id, Using = "Extension_ReportingPeriodId")]
        private IWebElement Extension_ReportingPeriod { get; set; }

        [FindsBy(How = How.Id, Using = "Extension_ExtensionDate")]
        private IWebElement Extension_Date { get; set; }

        [FindsBy(How = How.Id, Using = "regCreateButton")]
        private IWebElement CreateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[@class='sorting'][4]")]
        private IWebElement CreatedOnAscSort { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[@class='sorting_asc']")]
        private IWebElement CreatedOnDescSort { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[3]")]
        private IWebElement ExtensionResult_Date { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[6]/button")]
        private IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']/div[3]/a")]
        private IWebElement ConfirmDelete { get; set; }

        /// <summary>
        /// Clicks the create new report period extension.
        /// </summary>
        public void ClickonCreateNewReportPeriodExtension()
        {
            CreateNewReportReriodExtension.Click();
        }

        /// <summary>
        /// Fills in the extension details and click create.
        /// </summary>
        public void FillInExtensionDetailsAndClickCreate()
        {
            PageHelper.SelectValueFromDropdown(Site, "San Clinical Trials Unit");
            PageHelper.SelectValueFromDropdown(Extension_ReportingPeriod, "2015");
            Driver.ExecuteJavaScript(@"$('#Extension_ExtensionDate').val('01/01/2018')");
            CreateButton.Click();
        }

        /// <summary>
        /// Searches and verify the created extension.
        /// </summary>
        public void SearchAndVerifyTheCreatedExtension()
        {
            CreatedOnAscSort.Click();
            CreatedOnDescSort.Click();
            ExtensionResult_Date.Text.Should().BeEquivalentTo("01/01/2018");
        }

        /// <summary>
        /// Deletes the created extension.
        /// </summary>
        public void DeleteTheCreatedExtension()
        {
            PageHelper.WaitForElement(Driver, DeleteButton).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            PageHelper.WaitForElement(Driver, ConfirmDelete).Click();
        }
    }
}

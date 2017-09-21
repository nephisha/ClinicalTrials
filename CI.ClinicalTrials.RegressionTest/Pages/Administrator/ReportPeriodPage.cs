using System;
using System.Globalization;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    class ReportPeriodPage : PageBase
    {
        private readonly string rDescription = "RegTest" + PageHelper.RandomNumber(5);

        [FindsBy(How = How.Id, Using = "regCreateNewReportReriod")]
        private IWebElement CreateNewReportReriod { get; set; }

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "Description")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.Id, Using = "regBeginsOn")]
        private IWebElement BeginsOn { get; set; }

        [FindsBy(How = How.Id, Using = "BeginsOn")]
        private IWebElement EditedBeginsOn { get; set; }

        [FindsBy(How = How.Id, Using = "EndsOn")]
        private IWebElement EndsOn { get; set; }

        [FindsBy(How = How.Id, Using = "SubmissionDueDate")]
        private IWebElement SubmissionDueDate { get; set; }

        [FindsBy(How = How.Id, Using = "PaymentDate")]
        private IWebElement PaymentDate { get; set; }

        [FindsBy(How = How.Id, Using = "CalendarYear")]
        private IWebElement CalendarYear { get; set; }

        [FindsBy(How = How.Id, Using = "FiscalYear")]
        private IWebElement FiscalYear { get; set; }

        [FindsBy(How = How.Id, Using = "regCreateReportingPeriodButton")]
        private IWebElement CreateReportingPeriodButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        private IWebElement SaveReportingPeriodButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn']")]
        private IWebElement BackToList { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement ReportPeriodSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[2]")]
        private IWebElement ReportPeriodSearchResult_Desc { get; set; }

        [FindsBy(How = How.Id, Using = "regEditButton")]
        private IWebElement EditButton { get; set; }

        [FindsBy(How = How.Id, Using = "regDeleteButton")]
        private IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.Id, Using = "deleteReportPeriodConfirm")]
        private IWebElement ConfirmDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td")]
        private IWebElement NoResults { get; set; }

        /// <summary>
        /// Click to create new report period.
        /// </summary>
        public void ClickonCreateNewReportPeriod()
        {
            CreateNewReportReriod.Click();
        }

        /// <summary>
        /// Fills in report period details and click create.
        /// </summary>
        public void FillInReportPeriodDetailsAndClickCreate()
        {
            var dateString = BeginsOn.Text;
            var endDate = PageHelper.ConvertDateToFormat(dateString, "dd/MM/yyyy");
            var eDate = endDate.AddDays(2).ToString("dd/MM/yyyy");
            Name.SendKeys(endDate.ToString("dd/MM")+" - "+eDate.Substring(0,5));
            Description.SendKeys(rDescription);
            Driver.ExecuteJavaScript(@"$('#EndsOn').val('" + eDate + "')");
            Driver.ExecuteJavaScript(@"$('#SubmissionDueDate').val('" + eDate + "')");
            Driver.ExecuteJavaScript(@"$('#PaymentDate').val('" + eDate + "')");
            CalendarYear.Clear();
            CalendarYear.SendKeys(endDate.Year.ToString());
            FiscalYear.Clear();
            FiscalYear.SendKeys(endDate.Year.ToString());
            CreateReportingPeriodButton.Click();
            BackToList.Click();
        }

        /// <summary>
        /// Search and verify the created report period.
        /// </summary>
        public void SearchAndVerifyTheCreatedReportPeriod()
        {
            ReportPeriodSearch.SendKeys(rDescription);
            ReportPeriodSearchResult_Desc.Text.Should().BeEquivalentTo(rDescription);
        }

        /// <summary>
        /// Search and edit the report period.
        /// </summary>
        public void SearchAndEditTheReportPeriod()
        {
            ReportPeriodSearch.SendKeys(rDescription);
            EditButton.Click();

            var dateString = EditedBeginsOn.GetAttribute("value");
            var endDate = PageHelper.ConvertDateToFormat(dateString, "dd/MM/yyyy");
            var eDate = endDate.AddDays(2).ToString("dd/MM/yyyy");
            
            Description.Clear();
            Description.SendKeys("Edited" + rDescription);
            Driver.ExecuteJavaScript(@"$('#EndsOn').val('" + eDate + "')");
            Driver.ExecuteJavaScript(@"$('#SubmissionDueDate').val('" + eDate + "')");
            Driver.ExecuteJavaScript(@"$('#PaymentDate').val('" + eDate + "')");
            CalendarYear.SendKeys("2018");
            FiscalYear.SendKeys("2018");
            SaveReportingPeriodButton.Click();
            BackToList.Click();
        }

        /// <summary>
        /// Deletes the report period.
        /// </summary>
        public void DeleteTheReportPeriod()
        {
            DeleteButton.Click();
            PageHelper.WaitForElement(Driver, ConfirmDeleteButton).Click();
        }

        /// <summary>
        /// Search and verify the deleted report period.
        /// </summary>
        public void SearchAndVerifyTheDeletedReportPeriod()
        {
            ReportPeriodSearch.SendKeys(rDescription);
            NoResults.Text.Should().BeEquivalentTo("No results to show");
        }

        /// <summary>
        /// Search and verify the edited report period.
        /// </summary>
        public void SearchAndVerifyTheEditedReportPeriod()
        {
            ReportPeriodSearch.SendKeys("Edited" + rDescription);
            ReportPeriodSearchResult_Desc.Text.Should().BeEquivalentTo("Edited" + rDescription);
        }
    }
}

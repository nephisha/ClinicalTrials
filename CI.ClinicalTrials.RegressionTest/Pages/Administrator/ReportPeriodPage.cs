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

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini btn-primary']")]
        private IWebElement CreateNewReportReriod { get; set; }

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "Description")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='BeginsOn']/following-sibling::label")]
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

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        private IWebElement CreateReportingPeriodButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn']")]
        private IWebElement BackToList { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement ReportPeriodSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[2]")]
        private IWebElement ReportPeriodSearchResult_Desc { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini'][1]")]
        private IWebElement EditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='btn btn-mini btnDelete']")]
        private IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.Id, Using = "deleteReportPeriodConfirm")]
        private IWebElement ConfirmDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td")]
        private IWebElement NoResults { get; set; }

        public void ClickonCreateNewReportPeriod()
        {
            CreateNewReportReriod.Click();
        }

        public void FillInReportPeriodDetailsAndClickCreate()
        {
            var dateString = BeginsOn.Text;
            var endDate = PageHelper.ConvertDateToFormat(dateString, "dd/MM/yyyy");
            var eDate = endDate.AddDays(2).ToString("dd/MM/yyyy");

            Name.SendKeys("ReportPeriod Q3 2017");
            Description.SendKeys(rDescription);
            Driver.ExecuteJavaScript(@"$('#EndsOn').val('" + eDate + "')");
            Driver.ExecuteJavaScript(@"$('#SubmissionDueDate').val('" + eDate + "')");
            Driver.ExecuteJavaScript(@"$('#PaymentDate').val('" + eDate + "')");
            CalendarYear.SendKeys("2018");
            FiscalYear.SendKeys("2018");
            CreateReportingPeriodButton.Click();
            BackToList.Click();
        }
        
        public void SearchAndVerifyTheCreatedReportPeriod()
        {
            ReportPeriodSearch.SendKeys(rDescription);
            ReportPeriodSearchResult_Desc.Text.Should().BeEquivalentTo(rDescription);
        }

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
            CreateReportingPeriodButton.Click();
            BackToList.Click();
        }

        public void DeleteTheReportPeriod()
        {
            DeleteButton.Click();
            PageHelper.WaitForElement(Driver, ConfirmDeleteButton).Click();
        }

        public void SearchAndVerifyTheDeletedReportPeriod()
        {
            ReportPeriodSearch.SendKeys(rDescription);
            NoResults.Text.Should().BeEquivalentTo("No results to show");
        }

        public void SearchAndVerifyTheEditedReportPeriod()
        {
            ReportPeriodSearch.SendKeys("Edited" + rDescription);
            ReportPeriodSearchResult_Desc.Text.Should().BeEquivalentTo("Edited" + rDescription);
        }
    }
}

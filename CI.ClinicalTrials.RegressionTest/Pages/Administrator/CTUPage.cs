using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    public class CTUPage : PageBase
    {
        private string cName;

        [FindsBy(How = How.Id, Using = "regCreateNewCTU")]
        private IWebElement CreateNewCTU { get; set; }

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "Description")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.Id, Using = "SiteCode")]
        private IWebElement SiteCode { get; set; }

        [FindsBy(How = How.Id, Using = "LHDId")]
        private IWebElement LHD { get; set; }

        [FindsBy(How = How.Id, Using = "DepartmentHeadId")]
        private IWebElement ReportsSubmittedBy { get; set; }

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        private IWebElement CTUPhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "ReportingStartDate")]
        private IWebElement ReportingStartDate { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn")]
        private IWebElement BackToListButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement CTUSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[2]")]
        private IWebElement CTUSearchResult_Name { get; set; }

        [FindsBy(How = How.Id, Using = "regEditCTU")]
        private IWebElement EditCTU { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveCTUButton")]
        private IWebElement SaveCTUButton { get; set; }

        public void ClickonCreateNewCTU()
        {
            CreateNewCTU.Click();
        }

        public void FillInCTUDetailsAndClickCreate()
        {
            cName = "RegCTU" + PageHelper.RandomNumber(5);
            Name.SendKeys(cName);
            Description.SendKeys("CTU created by Regression Tests");
            SiteCode.SendKeys("Z"+ PageHelper.RandomNumber(3));
            PageHelper.PickRandomValueFromDropdown(LHD);
            PageHelper.PickRandomValueFromDropdown(ReportsSubmittedBy);
            CTUPhoneNumber.SendKeys(PageHelper.RandomNumber(10));
            Driver.ExecuteJavaScript(@"$('#ReportingStartDate').val('01/01/2017')");
            SaveCTUButton.Click();
            BackToListButton.Click();
        }

        public void SearchAndVerifyTheCreatedCTU()
        {
            CTUSearch.SendKeys(cName);
            CTUSearchResult_Name.Text.Should().BeEquivalentTo(cName);
        }
    }
}

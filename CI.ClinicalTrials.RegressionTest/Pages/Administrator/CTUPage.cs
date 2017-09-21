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

        [FindsBy(How = How.Id, Using = "Deprecated")]
        private IWebElement Deprecated { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn")]
        private IWebElement BackToListButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement CTUSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[2]")]
        private IWebElement CTUSearchResult_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[4]")]
        private IWebElement CTUSearchResult_Description { get; set; }

        [FindsBy(How = How.Id, Using = "regEditCTU")]
        private IWebElement EditCTU { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveCTUButton")]
        private IWebElement SaveCTUButton { get; set; }

        /// <summary>
        /// Click to create a new clinical trial unit.
        /// </summary>
        public void ClickonCreateNewCTU()
        {
            CreateNewCTU.Click();
        }

        /// <summary>
        /// Fills in the CTU details and click create.
        /// </summary>
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

        /// <summary>
        /// Searches and verify the created ctu.
        /// </summary>
        public void SearchAndVerifyTheCreatedCTU()
        {
            CTUSearch.SendKeys(cName);
            CTUSearchResult_Name.Text.Should().BeEquivalentTo(cName);
        }

        /// <summary>
        /// Searches and edit the ctu.
        /// </summary>
        public void SearchAndEditTheCTU()
        {
            CTUSearch.SendKeys(cName);
            PageHelper.WaitForElement(Driver, EditCTU).Click();
            Description.Clear();
            Description.SendKeys("Edited CTU details");
            SaveCTUButton.Click();
            BackToListButton.Click();
        }


        /// <summary>
        /// Searches and verify the edited ctu.
        /// </summary>
        public void SearchAndVerifyTheEditedCTU()
        {
            CTUSearch.SendKeys(cName);
            CTUSearchResult_Description.Text.Should().BeEquivalentTo("Edited CTU details");
        }

        /// <summary>
        /// Deprecates the clinical trial unit.
        /// </summary>
        /// <returns>System.String.</returns>
        public string DeprecateClinicalTrialUnit()
        {
            CTUSearch.SendKeys(cName);
            PageHelper.WaitForElement(Driver, EditCTU).Click();
            Deprecated.Click();
            SaveCTUButton.Click();
            BackToListButton.Click();
            return cName;
        }
    }
}

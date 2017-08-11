using System.Collections.Generic;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    class HospitalPage :PageBase
    {
        private readonly string hospital = "Reg_Hospital" + PageHelper.RandomNumber(5);

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini btn-primary']")]
        private IWebElement CreateNewHospital { get; set; }

        [FindsBy(How = How.Id, Using = "Text")]
        private IWebElement Text { get; set; }

        [FindsBy(How = How.Id, Using = "Deprecated")]
        private IWebElement Deprecated { get; set; }

        [FindsBy(How = How.Id, Using = "DisplayOrder")]
        private IWebElement DisplayOrder { get; set; }

        [FindsBy(How = How.Id, Using = "Type")]
        private IList<IWebElement> Type { get; set; }

        [FindsBy(How = How.Id, Using = "ReferenceNo")]
        private IWebElement ReferenceNo { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        private IWebElement CreateHospitalButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn']")]
        private IWebElement BackToList { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement HospitalSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[4]")]
        private IWebElement HospitalSearchResult_Name { get; set; }

        public void ClickonCreateNewHospital()
        {
            CreateNewHospital.Click();
        }

        public void FillInHospitalDetailsAndClickCreate()
        {
            Text.SendKeys(hospital);
            DisplayOrder.SendKeys(PageHelper.RandomNumber(2));
            PageHelper.PickRandomValueFromDropList(Type);
            ReferenceNo.SendKeys("Ref"+PageHelper.RandomString(5));
            CreateHospitalButton.Click();
            BackToList.Click();
        }

        public void SearchAndVerifyTheCreatedHospital()
        {
            HospitalSearch.SendKeys(hospital);
            HospitalSearchResult_Name.Text.Should().BeEquivalentTo(hospital);
        }
    }
}

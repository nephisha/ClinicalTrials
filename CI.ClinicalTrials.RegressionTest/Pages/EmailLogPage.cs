using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CI.ClinicalTrials.RegressionTest.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    class EmailLogPage : PageBase
    {
        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement EmailSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini']")]
        private IWebElement DetailsButton { get; set; }

        [FindsBy(How = How.Id, Using = "HtmlBody")]
        private IWebElement HTMLBody { get; set; }


        public string GetActivationLink(string email)
        {
            EmailSearch.SendKeys(email);
            DetailsButton.Click();
            var input = HTMLBody.Text;
            var result = input.Split(new[] { "href=\"" }, StringSplitOptions.None)[1]
                .Split('"')[0]
                .Trim();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CI.ClinicalTrials.RegressionTest.CommonMethods
{
    public static class PageHelper
    {
        private static readonly Random Random = new Random();

        public static void SelectValueFromDropList(IList<IWebElement> dropdownElement, string selectedTextValue)
        {
            var dSize = dropdownElement.Count;

            for (var i = 0; i < dSize; i++)
            {
                var value = dropdownElement.ElementAt(i).Text.ToLower();

                if (value.Contains(selectedTextValue.ToLower()))
                {
                    dropdownElement.ElementAt(i).Click();
                    break;
                }
            }
        }

        public static void PickRandomValueFromDropList(IList<IWebElement> droplistElement, List<string> excludedList = null)
        {
            var list = new List<string>();

            foreach (var t in droplistElement)
            {
                list.Add(t.Text);
            }

            if (excludedList == null)
            {
                var lSize = Random.Next(droplistElement.Count);
                droplistElement.ElementAt(lSize).Click();
            }
            else
            {
                var value = list.Except(excludedList).ToList();

                var dSize = droplistElement.Count;

                for (var i = 0; i < dSize; i++)
                {
                    if (droplistElement[i].Text.Equals(value[1]))
                    {
                        droplistElement.ElementAt(i).Click();
                        break;
                    }
                }
            }
        }

        public static IWebElement WaitForElement(IWebDriver driver, IWebElement element)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            return element;
        }

        public static void SelectValueFromDropdown(IWebElement category, string type)
        {
            var select = new SelectElement(category);
            select.SelectByText(type);
        }

        
        public static string RandomString(int length)
        {
            //var randomGuid = Guid.NewGuid();
            //return randomGuid.ToString();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumber(int length)
        {
            const string numbers = "0123456789";
            return new string(Enumerable.Repeat(numbers, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public static void PickRandomValueFromDropdown(IWebElement element)
        {
            var select = new SelectElement(element);
            var count = Random.Next(select.Options.Count);
            select.Options[1].Click();
        }

        public static void PickAllValuesFromDropdown(IWebElement element)
        {
            var select = new SelectElement(element);

            if (!select.IsMultiple) return;
            foreach (var option in select.Options)
                SetSelected(option, true);
        }

        private static void SetSelected(IWebElement option, bool select)
        {
            var selected = option.Selected;
            if ((selected || !select) && (!selected || select))
                return;
            option.Click();
        }

        public static string RandomEmailAddress()
        {
            return "test.user" + Random.Next(0, 10000) + "@cancerinstitute.com";
        }

        public static string EditedEmailAddress()
        {
            return "test_user" + Random.Next(0, 10000) + "@cancerinstitute.org";
        }

        public static DateTime ConvertDateToFormat(string dateString, string format)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            var result = DateTime.ParseExact(dateString, format, provider);
            return result;
        }

        public static void PickOnlyEnabledValueFromDropdown(IWebElement element)
        {
            var select = new SelectElement(element);
            var count = Random.Next(select.Options.Count);
            try
            {
                select.Options[2].Click();
            }
            catch (Exception)
            {
                count = Random.Next(select.Options.Count);
                select.Options[count].Click();
            }
        }
    }
}

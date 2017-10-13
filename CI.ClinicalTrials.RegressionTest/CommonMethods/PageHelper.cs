using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CI.ClinicalTrials.RegressionTest.CommonMethods
{
    /// <summary>
    /// List of all helper functions available
    /// </summary>
    public static class PageHelper
    {
        private static readonly Random Random = new Random();

        /// <summary>
        /// Selects the value from drop list.
        /// </summary>
        /// <param name="dropdownElement">The dropdown element.</param>
        /// <param name="selectedTextValue">The selected text value.</param>
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

        /// <summary>
        /// Picks the random value from drop list.
        /// </summary>
        /// <param name="droplistElement">The droplist element.</param>
        /// <param name="excludedList">The excluded list.</param>
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

        /// <summary>
        /// Waits for element to load.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="element">The element.</param>
        /// <returns>IWebElement.</returns>
        public static IWebElement WaitForElement(IWebDriver driver, IWebElement element)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            return element;
        }

        /// <summary>
        /// Selects the value from dropdown.
        /// </summary>
        /// <param name="selectWebElement">The select web element.</param>
        /// <param name="type">The type.</param>
        public static void SelectValueFromDropdown(IWebElement selectWebElement, string type)
        {
            var select = new SelectElement(selectWebElement);
            select.SelectByText(type);
        }


        /// <summary>
        /// Generates a Random String.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        public static string RandomString(int length)
        {
            //var randomGuid = Guid.NewGuid();
            //return randomGuid.ToString();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Generates a Random Number.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        public static string RandomNumber(int length)
        {
            const string numbers = "0123456789";
            return new string(Enumerable.Repeat(numbers, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Picks the random value from dropdown.
        /// </summary>
        /// <param name="element">The element.</param>
        public static void PickRandomValueFromDropdown(IWebElement element)
        {
            var select = new SelectElement(element);
            var count = Random.Next(select.Options.Count);
            select.Options[1].Click();
        }

        /// <summary>
        /// Picks all values from dropdown.
        /// </summary>
        /// <param name="element">The element.</param>
        public static void PickAllValuesFromDropdown(IWebElement element)
        {
            var select = new SelectElement(element);

            if (!select.IsMultiple) return;
            foreach (var option in select.Options)
                SetSelected(option, true);
        }

        /// <summary>
        /// Sets the selected option.
        /// </summary>
        /// <param name="option">The option.</param>
        /// <param name="select">if set to <c>true</c> [select].</param>
        private static void SetSelected(IWebElement option, bool select)
        {
            var selected = option.Selected;
            if ((selected || !select) && (!selected || select))
                return;
            option.Click();
        }

        /// <summary>
        /// Generates a Random Email address.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string RandomEmailAddress()
        {
            return "test.user" + Random.Next(0, 10000) + "@cancerinstitute.com";
        }

        /// <summary>
        /// Edit the Random Email address.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string EditedEmailAddress()
        {
            return "test_user" + Random.Next(0, 10000) + "@cancerinstitute.org";
        }

        /// <summary>
        /// Converts the date to format.
        /// </summary>
        /// <param name="dateString">The date string.</param>
        /// <param name="format">The format.</param>
        /// <returns>DateTime.</returns>
        public static DateTime ConvertDateToFormat(string dateString, string format)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            var result = DateTime.ParseExact(dateString, format, provider);
            return result;
        }

        /// <summary>
        /// Picks the only enabled value from dropdown.
        /// </summary>
        /// <param name="element">The element.</param>
        public static void PickOnlyEnabledValueFromDropdown(IWebElement element)
        {
            //var select = new SelectElement(element);
            //var count = Random.Next(select.Options.Count);
            //try
            //{
            //    select.Options[2].Click();
            //}
            //catch (Exception)
            //{
            //    count = Random.Next(select.Options.Count);
            //    select.Options[count].Click();
            //}

            var select = new SelectElement(element);
            var listElement = select.Options;
            
            for (int i = 0; i < listElement.Count; i++)
            {
                var t = listElement[i+1];
                if (t.Enabled)
                {
                    t.Click();  
                    break; 
                }
            }
        }
    }
}

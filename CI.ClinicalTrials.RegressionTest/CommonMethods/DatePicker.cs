using CI.ClinicalTrials.RegressionTest.Base;
using OpenQA.Selenium;

namespace CI.ClinicalTrials.RegressionTest.CommonMethods
{
    public class DatePicker : DriverBase
    {
        private const string SelectedDate = "20/07/2017";

        public void GetCurrentDay()
        {
            var today = Driver.FindElement(By.XPath("//a[@class='ui-state-default ui-state-highlight']"));

            var currMonth = Driver
                .FindElement(By.XPath("//*[@class=' ui-datepicker-days-cell-over  ui-datepicker-today']"))
                .GetAttribute("datamonth");

        }
    }
}

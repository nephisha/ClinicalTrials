using System;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Base
{
    public class PageBase : DriverBase
    {
        public PageBase()
        {
            var retry = new RetryingElementLocator(Driver, TimeSpan.FromSeconds(10));
            IPageObjectMemberDecorator decor = new DefaultPageObjectMemberDecorator();
            PageFactory.InitElements(retry.SearchContext, this, decor);
            //PageFactory.InitElements(Driver, this);
        }
        
    }
}

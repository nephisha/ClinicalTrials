using System;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Base
{
    /// <summary>
    /// This base page class is inherited by all the other pages 
    /// </summary>
    /// <seealso cref="CI.ClinicalTrials.RegressionTest.Base.DriverBase" />
    public class PageBase : DriverBase
    {
        /// <summary>
        /// <para> Implementation of Page Object Model </para>
        /// <para> PageFactory is a support class for the Selenium 2 Page Objects pattern </para>
        /// <para> RetryingElementLocator class used with the PageFactory which retries locating the element up to a timeout </para>
        /// Initializes all the page elements present in the DOM structure.
        /// 
        /// </summary>
        protected PageBase()
        {
            var retry = new RetryingElementLocator(Driver, TimeSpan.FromSeconds(10));
            IPageObjectMemberDecorator decor = new DefaultPageObjectMemberDecorator();
            PageFactory.InitElements(retry.SearchContext, this, decor);
            //PageFactory.InitElements(Driver, this);
        }
        
    }
}

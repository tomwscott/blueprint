using System.Collections.Generic;
using OpenQA.Selenium;

namespace Blueprint.Tests.Support.Pages
{
    public class QuotesPage : Page<QuotesPage>
    {
        public QuotesPage(Browser.Driver driver) : base(driver, "/quotes")
        {
        }

        public ICollection<IWebElement> Quotes
        {
            get { return driver.Dom.FindElements(By.ClassName("quote")); }
        }
    }
}
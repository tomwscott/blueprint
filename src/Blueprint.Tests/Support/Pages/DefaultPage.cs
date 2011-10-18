using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            get { return driver.Dom.FindElements(By.ClassName("quote") ); }
        }

        public string WibbleText
        {
            get { return driver.Dom.FindElement(By.ClassName("wibble")).Text; }
        }


        public void Alert()
        {
            driver.Execute("document.write('<p class=\"wibble\">Hello World</p>'); alert('done!');");
        }
    }

    public class DefaultPage : Page<DefaultPage>
    {
        public DefaultPage(Browser.Driver driver) : base(driver, "/")
        {
        }
    }
}
﻿using System.Collections.Generic;
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
            get { return driver.Dom.FindElements(By.ClassName("quotes")); }
        }
    }

    public class DefaultPage : Page<DefaultPage>
    {
        public DefaultPage(Browser.Driver driver) : base(driver, "/")
        {
        }
    }
}
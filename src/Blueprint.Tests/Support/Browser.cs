using System;
using OpenQA.Selenium;
using Plasma.WebDriver;

namespace Blueprint.Tests.Support
{
    public class Browser
    {
        private readonly Driver driver;

        private Browser(Driver driver)
        {
            this.driver = driver;
        }

        public static void Initialise(Driver driver)
        {
            Current = new Browser(driver);
        }

        public static Browser Current { get; private set; }


        public SpecificPage NavigateTo<SpecificPage>() where SpecificPage : Page<SpecificPage>
        {
            return Page<SpecificPage>.Open(driver);
        }

        public interface Driver : IDisposable
        {
            IWebDriver Dom { get; }
            void NavigateTo(string location);
            void Execute(string script);
        }

        public static void Close()
        {
            Current.driver.Dispose();
        }
    }
}
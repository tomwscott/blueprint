using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Blueprint.Tests.Support.Web
{
    public class FirefoxWebDriver : Browser.Driver
    {
        private readonly FirefoxDriver driver;

        public FirefoxWebDriver()
        {
            driver = new FirefoxDriver();
        }

        public IWebDriver Dom
        {
            get { return driver; }
        }

        public void NavigateTo(string location)
        {
            driver.Navigate().GoToUrl("http://localhost/blueprint" + location);
        }

        public void Execute(string script)
        {
            driver.ExecuteScript(script);
        }

        public void Dispose()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
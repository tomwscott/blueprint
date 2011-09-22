using System;

namespace Blueprint.Tests.Support
{
    public class Page<SpecificPage> where SpecificPage : Page<SpecificPage>
    {
        protected readonly Browser.Driver driver;
        private readonly string location;

        protected Page(Browser.Driver driver, string location)
        {
            this.driver = driver;
            this.location = location;
        }

        public string Title
        {
            get { return driver.Dom.Title; }
        }

        public static SpecificPage Open(Browser.Driver driver)
        {
            var page = ((SpecificPage) Activator.CreateInstance(typeof (SpecificPage), driver));
            page.driver.NavigateTo(page.location);
            return page;
        }
    }
}
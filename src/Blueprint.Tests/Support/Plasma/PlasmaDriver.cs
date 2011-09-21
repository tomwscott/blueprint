using System.Collections.ObjectModel;
using System.IO;
using OpenQA.Selenium;
using Plasma.Core;
using Plasma.WebDriver;

namespace Blueprint.Tests.Support.Plasma
{
    public class PlasmaDriver : Browser.Driver
    {
        private readonly AspNetApplication webApplication;
        private AspNetResponse currentResponse;

        public PlasmaDriver()
        {
            var physicalPath = Path.GetFullPath("../../../Blueprint.Web");
            webApplication = new AspNetApplication("/", physicalPath);
            NavigateTo("/");
        }

        public void NavigateTo(string location)
        {
            currentResponse = webApplication.ProcessRequest(location);
        }

        public IWebDriver Dom
        {
            get { return new PlasmaDom(currentResponse); }
        }

        public class PlasmaDom : IWebDriver
        {
            private readonly AspNetResponse response;
            private readonly HtmlNavigator html;

            public PlasmaDom(AspNetResponse response)
            {
                this.response = response;
                this.html = response.Html();
            }

            public IWebElement FindElement(By @by)
            {
                return html.FindElement(by);
            }

            public ReadOnlyCollection<IWebElement> FindElements(By @by)
            {
                return html.FindElements(by);
            }

            public void Dispose()
            {
            }

            public void Close()
            {
            }

            public void Quit()
            {
            }

            public IOptions Manage()
            {
                throw new System.NotImplementedException();
            }

            public INavigation Navigate()
            {
                throw new System.NotImplementedException();
            }

            public ITargetLocator SwitchTo()
            {
                throw new System.NotImplementedException();
            }

            public string Url
            {
                get { return response.Url; }
                set { throw new System.NotImplementedException(); }
            }

            public string Title
            {
                get { return html.Title; }
            }

            public string PageSource
            {
                get { return response.ToEntireResponseString(); }
            }

            public string CurrentWindowHandle
            {
                get { throw new System.NotImplementedException(); }
            }

            public ReadOnlyCollection<string> WindowHandles
            {
                get { throw new System.NotImplementedException(); }
            }
        }

        public void Dispose()
        {
            webApplication.Close();
        }
    }
}
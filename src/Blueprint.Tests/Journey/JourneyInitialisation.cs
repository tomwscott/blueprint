using Blueprint.Tests.Support;
using Blueprint.Tests.Support.Web;
using NUnit.Framework;

namespace Blueprint.Tests.Journey
{
    [SetUpFixture]
    public class JourneyInitialisation
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialise(new FirefoxWebDriver());
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Close();
        }
    }
}
using Blueprint.Tests.Support;
using Blueprint.Tests.Support.Plasma;
using Blueprint.Tests.Support.Web;
using NUnit.Framework;

namespace Blueprint.Tests.Acceptance
{
    [SetUpFixture]
    public class AcceptanceTestInitialisation
    {
        [SetUp]
        public void SetUp()
        {
//            Browser.Initialise(new PlasmaDriver());
            Browser.Initialise(new FirefoxWebDriver());
        }
    }
}
using Blueprint.Tests.Support;
using Blueprint.Tests.Support.Plasma;
using NUnit.Framework;

namespace Blueprint.Tests.Acceptance
{
    [SetUpFixture]
    public class AcceptanceTestInitialisation
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialise(new PlasmaDriver());
        }
    }
}
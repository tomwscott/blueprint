using Blueprint.Tests.Support;
using Blueprint.Tests.Support.Pages;
using NUnit.Framework;

namespace Blueprint.Tests.Journey
{
    [TestFixture]
    public class BasicJourneyTests
    {
        [Test]
        public void ShouldOpenFirefoxAndNavigateThroughPages()
        {
            var page = Browser.Current.NavigateTo<DefaultPage>();
            Assert.That(page.Title, Is.EqualTo("Default View"));
        }
    }
}
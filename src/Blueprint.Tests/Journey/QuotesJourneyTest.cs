using Blueprint.Tests.Support;
using Blueprint.Tests.Support.Pages;
using NUnit.Framework;

namespace Blueprint.Tests.Journey
{
    [TestFixture]
    public class QuotesJourneyTest
    {
        [Test]
        public void ShouldDisplayAListOfQuotes()
        {
            var page = Browser.Current.NavigateTo<QuotesPage>();
            Assert.That(page.Quotes.Count, Is.GreaterThan(0));
        } 
    }
}
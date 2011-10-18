using Blueprint.Tests.Support;
using Blueprint.Tests.Support.Pages;
using NUnit.Framework;

namespace Blueprint.Tests.Acceptance
{
    [TestFixture]
    public class DefaultAcceptanceTests
    {
        [Test]
        public void ShouldUpdateTitleToReflectPage()
        {
            var page = Browser.Current.NavigateTo<DefaultPage>();
            Assert.That(page.Title, Is.EqualTo("Default View"));

//            Assert.That(page.Time, Is.EqualTo(someTimeThatISet));
        }
    }
}
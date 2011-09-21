using System;
using Blueprint.Tests.Support;
using Blueprint.Tests.Support.Stubs;
using Blueprint.Web.Controllers;
using NUnit.Framework;

namespace Blueprint.Tests.Unit.Controllers
{
    public class DefaultControllerTests
    {
        [Test]
        public void ShouldDetermineTheCurrentTime()
        {
            var clock = new StubClock{Now = DateTime.Now};
            var controller = new DefaultController(clock);

            var result = controller.Index().As<DefaultViewModel>();

            Assert.That(result.Time, Is.EqualTo(clock.Now));
        }
    }
}
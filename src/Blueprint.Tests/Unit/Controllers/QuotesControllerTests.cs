using System.Collections.Generic;
using System.Web.Mvc;
using Blueprint.Web.Controllers;
using Blueprint.Web.Services;
using NUnit.Framework;
using Rhino.Mocks;

namespace Blueprint.Tests.Unit.Controllers
{
    [TestFixture]
    public class QuotesControllerTests
    {
        private MockRepository repo = new MockRepository();

        [Test]
        public void ShouldRetrieveQuotesFromRepository()
        {
            // Given
            IList<int> quotes = new List<int>{5,4,3};
            IQuotesRepository repository = new StubQuotesRepository(quotes);
            var controller = new QuotesController(repository);

            repository.Expect(r=> r.FindAll()).Return(quotes);

            // When
            var model = (QuotesModel)((ViewResult) controller.Index()).Model;
            // Then

            Assert.That(model.Quotes, Is.EqualTo(quotes));
        }
        
        [Test]
        public void ShouldRetrieveADifferentListOfQuotesFromRepository()
        {
            // Given
            IList<int> quotes = new List<int>{1,2,3};
            IQuotesRepository repository = new StubQuotesRepository(quotes);
            var controller = new QuotesController(repository);

            // When
            var model = (QuotesModel)((ViewResult) controller.Index()).Model;
            // Then

            Assert.That(model.Quotes, Is.EqualTo(quotes));
        }

        public class StubQuotesRepository : IQuotesRepository
        {
            private readonly IList<int> quotes;

            public StubQuotesRepository(IList<int> quotes)
            {
                this.quotes = quotes;
            }

            public IList<int> FindAll()
            {
                return quotes;
            }
        }
    }
}
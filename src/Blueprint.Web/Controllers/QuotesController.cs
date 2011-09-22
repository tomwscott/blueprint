using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blueprint.Web.Services;

namespace Blueprint.Web.Controllers
{
    public class QuotesController : Controller
    {
        private readonly IQuotesRepository repository;

        public QuotesController(IQuotesRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var quotes = repository.FindAll();
            return View(new QuotesModel(quotes));
        }
    }

    public class QuotesModel
    {
        public IList<int> Quotes { get; set; }

        public QuotesModel(IList<int> quotes)
        {
            Quotes = quotes;
        }
    }
}

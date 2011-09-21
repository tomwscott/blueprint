using System;
using System.Web.Mvc;
using Blueprint.Web.Services;

namespace Blueprint.Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IClock clock;

        public DefaultController(IClock clock)
        {
            this.clock = clock;
        }

        public ActionResult Index()
        {
            return View(new DefaultViewModel(clock.Now));
        }

    }

    public class DefaultViewModel
    {
        public DefaultViewModel(DateTime now)
        {
            Time = now;
        }

        public DateTime Time { get; private set; }
    }
}

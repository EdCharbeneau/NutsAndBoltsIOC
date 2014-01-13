using NutsAndBoltsIOC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutsAndBoltsIOC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationService _service;

        public HomeController(IApplicationService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            ViewBag.Foo = _service.DisplayFoo();
            ViewBag.Bar = _service.DisplayBar();
            ViewBag.Baz = _service.DisplayBaz();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
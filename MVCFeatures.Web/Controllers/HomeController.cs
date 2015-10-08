using MVCFeatures.Web.CustomBinders;
using MVCFeatures.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFeatures.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomBinder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomBinder([ModelBinder(typeof(UserDtoBinder))]UserDto userDto)
        {
            return View(userDto);
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
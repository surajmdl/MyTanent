using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTannent.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }


        public ActionResult Dashboard()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult MyAccount()
        {
            string uid = Convert.ToString(Session["Id"]);

            if (string.IsNullOrEmpty(uid))
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                Guid val = Guid.Parse(uid);
                return RedirectToAction("ProfileView", "User", new { id = val });
            }
        }

        public ActionResult Bookings()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyWallet()
        {
            return View();
        }
    }
}

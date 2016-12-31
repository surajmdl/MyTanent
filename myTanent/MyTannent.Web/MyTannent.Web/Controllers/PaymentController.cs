using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTannent.Web.Controllers
{
    public class PaymentController : BaseController
    {
        //
        // GET: /Payment/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Payment/Details/5

        public ActionResult PayRent()
        {
            return View();
        }

        public ActionResult PaymentHistory()
        {
            return View();
        }

    }
}

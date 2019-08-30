using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS1.Controllers
{
    public class CustomerPageController : Controller
    {
        // GET: CustomerPage
        public ActionResult UserPage()
        {
            return View();
        }
        [HttpPost]

        public ActionResult UserPage()
        {
            return View();
        }

        public ActionResult PaymentGateway()
        {
            return View();
        }

        [HttpPost]

        public ActionResult PaymentGateway()
        {
            return View();
        }

    }
}
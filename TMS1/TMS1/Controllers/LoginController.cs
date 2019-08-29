using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMS1.Models;

namespace TMS1.Controllers
{
    public class LoginController : Controller
    {
        tmsdbEntities db = new tmsdbEntities();
        // GET: Login
        public ActionResult HomePage()
        {
            return View();
        }
    }
}
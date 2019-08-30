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

        //public ActionResult HomePage()
        //{
        //    return View();
        //}

        
        public ActionResult RTOLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RTOLogin()
        {
             = Request.Form["txtun"].ToString();
            pass = Request.Form["txtp"].ToString();

            var res = db.TM_UserMaster.Where(x => x.username == uname && x.pass == pass).SingleOrDefault();


            if (res == null)
            {
                ModelState.AddModelError("", "Invalid");
            }
            else
            {
                ModelState.AddModelError("", "Login Successfull");

                return View();
        }


        //public ActionResult PoliceLogin()
        //{
        //    return View();
        //}

        //[HttpPost]

        //public ActionResult PoliceLogin()
        //{
        //    return View();
        //}

        //public ActionResult UserLogin()
        //{
        //    return View();
        //}

        //[HttpPost]

        //public ActionResult UserLogin()
        //{
        //    return View();
        //}


    }
}
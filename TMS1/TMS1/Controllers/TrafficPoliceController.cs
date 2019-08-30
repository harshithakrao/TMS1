using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS1.Controllers
{
    public class TrafficPoliceController : Controller
    {
        // GET: TrafficPolice
        public ActionResult Home_traffic()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Home_traffic(int VehicleNo)// change the parameter according to need
        {
            return View();
        }

        [HttpGet]
        public ActionResult OffenceRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OffenceRegister(string VehicleNo)
        {
            return View();
        }

        [HttpGet]

        public ActionResult OffenceStatus()
        {
            return View();
        }

        [HttpPost]

        public ActionResult OffenceStatus(int VehicleNo)
        {
            return View();
        }
        
    }
}
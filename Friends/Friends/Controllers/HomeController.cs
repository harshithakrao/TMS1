using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Friends.Models;

namespace Friends.Controllers
{
    public class HomeController : Controller
    {
        masterEntities db = new masterEntities();


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(string name,string place)
        {
            name = Request.Form["txtfname"].ToString();
            place= Request.Form["txtplace"].ToString();

            if(name==null)
            {
                ModelState.AddModelError("", "Name can't be empty");
            }
            if (place == null)
            {
                ModelState.AddModelError("", "Place can't be empty");
            }

           
            
            return View();
        }


        public ActionResult Edit()
        {
            var data = db.friends;
            return View(data);
        }

        

        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(int id,string name,string place)
        {
            id = Convert.ToInt32(Session["fid"]);
            name = Request.Form["txtfname"].ToString();
            place = Request.Form["txtplace"].ToString();

            var ud = db.friends.Where(x => x.fid == id).SingleOrDefault();
            ud.fname = name;
            ud.place = place;
            var res = db.SaveChanges();
            if(res>0)
            {
                ModelState.AddModelError("", "Updated successfully");
            }
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            id = Convert.ToInt32(Session["fid"]);

            var res = db.SaveChanges();
            //if(res)
            //{
            //    ModelState.AddModelError("", "Deleted Successfully");
            //}
            return View();
        }
    }
}
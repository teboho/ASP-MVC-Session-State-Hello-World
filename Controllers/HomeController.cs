using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session_State_Hello_World.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //HttpCookie cook = new HttpCookie("time");
            //cook.Secure = true;
            //cook.HttpOnly = true;
            //cook.Value = ""+29;
            return View();
        }
        
        public ActionResult LoggedIn()
        {
            return View();
        }

        // POST: /Home/SaveState
        [HttpPost]
        public ActionResult SaveState(FormCollection collection)
        {
            if (collection["name"].Equals("") || collection["name"].Equals(null)) {
                Response.Redirect("Index");
            }
            this.Session["name"] = collection["name"];
            this.Session["type"] = collection["type"];

            return View("LoggedIn");
        }

        public ActionResult LogOut()
        {
            this.Session["name"] = null;
            this.Session["type"] = null;

            ViewBag.Message = "Logged Out";
            //Response.Redirect("index");
            return View("Index");
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}
    }
}
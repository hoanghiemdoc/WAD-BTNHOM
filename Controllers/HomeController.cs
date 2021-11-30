using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAD_BTNHOM.Models.Entities;

namespace WAD_BTNHOM.Controllers
{
    public class HomeController : Controller
    {
        private WAD_BTNHOMEntities context = new WAD_BTNHOMEntities();
        public ActionResult Index()
        {
            var user = context.Users.ToList();
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
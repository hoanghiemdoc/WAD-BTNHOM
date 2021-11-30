using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAD_BTNHOM.Models;

namespace WAD_BTNHOM.Controllers
{
    public class CategoriesController : Controller
    {
        private DataContext context = new DataContext();
        // GET: Categories
        public ActionResult Category()
        {
            ViewData["Page-Title"] = "Categories Pagesssss";
            ViewBag.PageTitle = "Demo title for Categories Page";


            // ket noi model database
            var list = context.Categories.ToList();
            list.Add(new Category() { Id = 1, CategoryName = "fashion" });
            list.Add(new Category() { Id = 2, CategoryName = "snacker" });
            list.Add(new Category() { Id = 3, CategoryName = "gucci" });
            return View(list);  // parse sing model category
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }

        public ActionResult Brand()
        {
            return View();
        }

        public new ActionResult User()
        {
            return View();
        }



    }
}
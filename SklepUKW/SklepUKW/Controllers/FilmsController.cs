using SklepUKW.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepUKW.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db = new FilmsContext();
        // GET: Films
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToLower() == categoryName.ToLower()).Single();
            return View(category.Films.ToList());
        }

        public ActionResult Details(int id)
        {
            var film = db.Films.Find(id);
            return View(film);
        }

        [ChildActionOnly]
        public ActionResult CategoriesMenu()
        {
            var categoryList = db.Categories.ToList();
            return PartialView("_CategoriesMenu", categoryList);
        }

        [ChildActionOnly]
        public ActionResult FilmsFromCategory(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToLower() == categoryName.ToLower()).Single();
            return PartialView("_FilmsFromCategory", category.Films.ToList());
        }
    }
} 
    }
}
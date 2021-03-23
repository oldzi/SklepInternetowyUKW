using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklep.Models;
using Sklep.DAL;

namespace Sklep.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db = new FilmsContext();
        // GET: Home
        public ActionResult Index()
        {
            Category category = new Category()
            {
                CategoryId = 1,
                Name = "Horror",
                Desc = "Filmy od lat 16"

            };
            db.Categories.Add(category);
            db.SaveChanges();
            return View();
        }
    }
}
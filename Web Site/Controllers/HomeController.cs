using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Site.Classes;
using Web_Site.Models;

namespace Web_Site.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var latestPosts = db.Listings
               .Include(p => p.Author)
               .Include(p => p.Files)
               .OrderByDescending(p => p.Date)
               .Take(6);
            return View(latestPosts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            this.AddNotification("Many regards from our team!", NotificationType.SUCCESS);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
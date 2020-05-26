using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SimpleUser.Models;

namespace SimpleUser.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View(context.Users.ToList());
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
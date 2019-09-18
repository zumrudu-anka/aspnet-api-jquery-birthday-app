using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DavetiyeFormu() {
            return View();
        }

        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel davetiye)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(davetiye);
                return View("Thanks", davetiye);
            }
            return View(davetiye);
        }

        public ActionResult TumListe()
        {
            return View(Veritabani.Liste);
        }
    }
}
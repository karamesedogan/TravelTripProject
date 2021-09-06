using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using TravelTripProject.Models.Sınıflar;
using Context = TravelTripProject.Models.Sınıflar.Context;


namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        private Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkındas.ToList();
            return View(degerler);
        }
    }
}
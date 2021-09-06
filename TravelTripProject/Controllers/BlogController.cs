using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TravelTripProject.Models.Sınıflar;


namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            BlogYorum by = new BlogYorum();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(3).ToList();

            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            BlogYorum by = new BlogYorum();

            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();

            return View(by);
        }
    }
}
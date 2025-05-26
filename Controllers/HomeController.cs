using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Practical_7.Models; 
using Practical_7.Data;

namespace Practical_7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Retrieves info from the data repository
            var publications = FakeDataRepository.GetPublications();

            // add data to the view
            return View(publications);
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

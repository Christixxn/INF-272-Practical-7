using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_7.Data;
using Practical_7.Models;

namespace Practical_7.Controllers
{
    public class PublicationController : Controller
    {
        public ActionResult Index()
        {
            var publications = FakeDataRepository.GetPublications();
            return View(publications);
        }
    }
}


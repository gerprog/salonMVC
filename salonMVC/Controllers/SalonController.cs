using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace salonMVC.Controllers
{
    public class SalonController : Controller
    {
        //
        // GET: /Salon/
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Salon/Browse?treatment=Hairdye
        public string Browse(string treatment)
        {
            string message = HttpUtility.HtmlEncode("Salon.Browse, Treatment = " + treatment);

            return message;
        }
        //
        // GET: /Salon/Details
        public string Details(int id)
        {
            string message = "Salon.Details, ID = " + id;
            return message;
        }
    }
}
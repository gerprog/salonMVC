using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using salonMVC.Models;

namespace salonMVC.Controllers
{
    public class SalonController : Controller
    {
        SalonEntities salonDB = new SalonEntities();
        //
        // GET: /Salon/
        public ActionResult Index()
        {
            var treatmentTypes = salonDB.TreatmentTypes.ToList();
            return View(treatmentTypes);
        }
        //
        // GET: /Salon/Browse?treatment=Hairdye
        public ActionResult Browse(string treatmentType)
        {
            // Retrieve TreatmentType and its Associated Treatments from database
            var treatmentTypeModel = salonDB.TreatmentTypes.Include("Treatments")
                .Single(g => g.Name == treatmentType);

            return View(treatmentTypeModel);
        }
        //
        // GET: /Salon/Details
        public ActionResult Details(int id)
        {
            var treatment = new Treatment { TreatmentName = "Treatment " + id };
            return View(treatment);
        }
    }
}
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
        //
        // GET: /Salon/
        public ActionResult Index()
        {
            var treatmentTypes = new List<TreatmentType>
            {
                new TreatmentType { Name = "Hair Styles"},
                new TreatmentType { Name = "Hair Cuts"},
                new TreatmentType { Name = "Facial Treaments"},
                new TreatmentType { Name = "Nail Treaments"}
            };
            return View(treatmentTypes);
        }
        //
        // GET: /Salon/Browse?treatment=Hairdye
        public ActionResult Browse(string treatmentType)
        {
            var treatmentTypeModel = new TreatmentType { Name = treatmentType };

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
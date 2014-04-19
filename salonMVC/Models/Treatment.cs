using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using salonMVC.Models;

namespace salonMVC.Models
{
    public class Treatment
    {
        public string TreatmentName { get; set; }
        public TreatmentType TreatmentType { get; set; }
    }
}
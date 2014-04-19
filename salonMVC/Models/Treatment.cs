using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using salonMVC.Models;

namespace salonMVC.Models
{
    public class Treatment
    {
        public int TreatmentId { get; set; }
        public int TreatmentTypeId { get; set; }
        public int StylistId { get; set; }
        public string TreatmentName { get; set; }
        public decimal Price { get; set; }
        public string TreatmentPicUrl { get; set; }
        public TreatmentType TreatmentType { get; set; }
        public Stylist Stylist { get; set; }
    }
}
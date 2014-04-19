using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using salonMVC.Models;

namespace salonMVC.Models
{
    public partial class TreatmentType
    {
        public int TreatmentTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Treatment> Treatments { get; set; }
    }
}
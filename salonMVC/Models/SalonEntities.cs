using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace salonMVC.Models
{
    public class SalonEntities : DbContext
    {
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<TreatmentType> TreatmentTypes { get; set; }

        public System.Data.Entity.DbSet<salonMVC.Models.Stylist> Stylists { get; set; }
    }
}
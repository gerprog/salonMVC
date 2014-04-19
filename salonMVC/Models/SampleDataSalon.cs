using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SalonMvc.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<SalonEntities>
    {
        protected override void Seed(SalonEntities context)
        {
            var treatmentTypes = new List<TreatmentType>
            {
                new TreatmentType { Name = "Women's Hair" },
                new TreatmentType { Name = "Men's Hair" },
                new TreatmentType { Name = "Children's Hair" },
                new TreatmentType { Name = "Wax Treatments" },
                new TreatmentType { Name = "Hair Removal" },
                new TreatmentType { Name = "Nail Treatments" },
				new TreatmentType { Name = "Facial Treatments" }
            };

            var stylists = new List<Stylist>
            {
                new Stylist { Name = "Karen Conway" },
                new Stylist { Name = "Girts Bralis" },
                new Stylist { Name = "Javier Rossetti" },
                new Stylist { Name = "Sanjeev Kumar" },
                new Stylist { Name = "Paul Mannion" },
                new Stylist { Name = "Gerard Daly" },
                new Stylist { Name = "Karen Rooney" },
				new Stylist { Name = "Sandra McCormack" }
            };

            new List<Treatment>
            {
                new Treatment { TreatmentName = "Conditioning Treatment", TreatmentType = treatmentTypes.Single(g => g.Name == "Women's Hair"), Price = 38.99, Stylist = stylists.Single(a => a.Name == "Karen Conway"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Dry Hair Treatment", TreatmentType = treatmentTypes.Single(g => g.Name == "Women's Hair"), Price = 18.99, Stylist = stylists.Single(a => a.Name == "Karen Conway"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
                new Treatment { TreatmentName = "Ladies Cut and Finish", TreatmentType = treatmentTypes.Single(g => g.Name == "Women's Hair"), Price = 54.99, Stylist = stylists.Single(a => a.Name == "Sanjeev Kumar"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Power Blow Dry", TreatmentType = treatmentTypes.Single(g => g.Name == "Women's Hair"), Price = 29.99, Stylist = stylists.Single(a => a.Name == "Sanjeev Kumar"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Semi-permanent", TreatmentType = treatmentTypes.Single(g => g.Name == "Women's Hair"), Price = 28.99, Stylist = stylists.Single(a => a.Name == "Javier Rossetti"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Roots Tint", TreatmentType = treatmentTypes.Single(g => g.Name == "Women's Hair"), Price = 43.99, Stylist = stylists.Single(a => a.Name == "Gerard Daly"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Full Tint", TreatmentType = treatmentTypes.Single(g => g.Name == "Women's Hair"), Price = 38.99, Stylist = stylists.Single(a => a.Name == "Karen Rooney"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Gents Cut and Finish", TreatmentType = treatmentTypes.Single(g => g.Name == "Men's Hair"), Price = 18.99, Stylist = stylists.Single(a => a.Name == "Paul Mannion"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Gents Beard Trim", TreatmentType = treatmentTypes.Single(g => g.Name == "Men's Hair"), Price = 15.99, Stylist = stylists.Single(a => a.Name == "Paul Mannion"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Children's Cut and Wash", TreatmentType = treatmentTypes.Single(g => g.Name == "Children's Hair"), Price = 13.99, Stylist = stylists.Single(a => a.Name == "Sandra McCormack"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Waxing", TreatmentType = treatmentTypes.Single(g => g.Name == "Wax Treatments"), Price = 30.99, Stylist = stylists.Single(a => a.Name == "Girts Bralis"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Hair removal", TreatmentType = treatmentTypes.Single(g => g.Name == "Hair Removal"), Price = 25.99, Stylist = stylists.Single(a => a.Name == "Girts Bralis"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Manicure", TreatmentType = treatmentTypes.Single(g => g.Name == "Nail Treatments"), Price = 27.99, Stylist = stylists.Single(a => a.Name == "Karen Conway"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Pedicure", TreatmentType = treatmentTypes.Single(g => g.Name == "Nail Treatments"), Price = 27.99, Stylist = stylists.Single(a => a.Name == "Karen Conway"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				new Treatment { TreatmentName = "Fresh Face", TreatmentType = treatmentTypes.Single(g => g.Name == "Facial Treatments"), Price = 20.99, Stylist = stylists.Single(a => a.Name == "Karen Rooney"), TreatmentPicUrl = "/Content/Images/placeholder.gif" },
				
				
            }.ForEach(a => context.Treatments.Add(a));
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNP.Models
{
    public class PnpLocation
    {
        [Key]
        public int pnpLocationID { get; set; }
        [Display(Name = "Store Name")]
        public string pnpLocationName { get; set; }
        [Display(Name = "Street")]
        public string pnpLocationStreetAddress { get; set; }
        [Display(Name = "Suburb")]
        public string pnpLocationSuburbAddress { get; set; }
        [Display(Name = "Code")]
        public string pnpLocationCodeAddress { get; set; }
        [Display(Name = "Co-ordinates Location")]
        public string pnpLocationCoordinates { get; set; }

        public ICollection<PnpSales> Sales { get; set; }
    }
}
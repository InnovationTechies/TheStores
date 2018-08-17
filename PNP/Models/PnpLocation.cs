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
        public int PnpLocationID { get; set; }
        [Display(Name = "Store Name")]
        public string PnpLocationName { get; set; }
        [Display(Name = "Street")]
        public string PnpLocationStreetAddress { get; set; }
        [Display(Name = "Suburb")]
        public string PnpLocationSuburbAddress { get; set; }
        [Display(Name = "Code")]
        public string PnpLocationCodeAddress { get; set; }
        [Display(Name = "Co-ordinates Location")]
        public string PnpLocationCoordinates { get; set; }

        public ICollection<PnpSales> Sales { get; set; }
    }
}
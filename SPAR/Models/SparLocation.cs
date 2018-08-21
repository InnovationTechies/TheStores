using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAR.Models
{
    public class SparLocation
    {
        [Key]
        public int sparLocationID { get; set; }
        [Display(Name = "Store Name")]
        public string sparLocationName { get; set; }
        [Display(Name = "Street")]
        public string sparLocationStreetAddress { get; set; }
        [Display(Name = "Suburb")]
        public string sparLocationSuburbAddress { get; set; }
        [Display(Name = "Code")]
        public string sparLocationCodeAddress { get; set; }
        [Display(Name = "Co-ordinates Location")]
        public string sparLocationCoordinates { get; set; }

    }
}
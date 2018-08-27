using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CHECKERS.Models
{
    public class CheckersLocation
    {
        [Key]
        public int CheckersLocationID { get; set; }
        [Display(Name = "Store Name")]
        public string CheckersLocationName { get; set; }
        [Display(Name = "Street")]
        public string CheckersLocationStreetAddress { get; set; }
        [Display(Name = "Suburb")]
        public string CheckersLocationSuburbAddress { get; set; }
        [Display(Name = "Code")]
        public string CheckersLocationCodeAddress { get; set; }
        [Display(Name = "Co-ordinates Location")]
        public string CheckersLocationCoordinates { get; set; }

        public ICollection<CheckersSales> Sales { get; set; }
    }
}
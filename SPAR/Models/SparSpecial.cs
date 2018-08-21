using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAR.Models
{
    public class SparSpecial
    {
        [Key]
        public int sparSpecialID { get; set; }
        [Display(Name = "Name")]
        public string sparSpecialName { get; set; }
        [Display(Name = "Description")]
        public string sparSpecialDesc { get; set; }
        [Display(Name = "Start Date")]
        public DateTime sparStartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime sparEndDate { get; set; }

    }
}
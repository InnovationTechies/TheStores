using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNP.Models
{
    public class PnpSpecial
    {
        [Key]
        public int pnpSpecialID { get; set; }
        [Display(Name = "Name")]
        public string pnpSpecialName { get; set; }
        [Display(Name = "Description")]
        public string pnpSpecialDesc { get; set; }
        [Display(Name = "Start Date")]
        public DateTime pnpStartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime pnpEndDate { get; set; }

        public ICollection<PnpSales> Sales { get; set; }




    }
}
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
        public int PnpSpecialID { get; set; }
        [Display(Name = "Name")]
        public string PnpSpecialName { get; set; }
        [Display(Name = "Description")]
        public string PnpSpecialDesc { get; set; }
        [Display(Name = "StartDate")]
        public DateTime PnpStartDate { get; set; }
        [Display(Name = "EndDate")]
        public DateTime PnpEndDate { get; set; }

        //public ICollection<PnpSales> Sales { get; set; }




    }
}
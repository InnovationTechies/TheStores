using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CHECKERS.Models
{
    public class CheckersSpecials
    {
        [Key]
        public int CheckersSpecialID { get; set; }
        [Display(Name = "Name")]
        public string CheckersSpecialName { get; set; }
        [Display(Name = "Description")]
        public string CheckersSpecialDesc { get; set; }
        [Display(Name = "StartDate")]
        public DateTime CheckersStartDate { get; set; }
        [Display(Name = "EndDate")]
        public DateTime CheckersEndDate { get; set; }

        //public ICollection<PnpSales> Sales { get; set; }
    }
}
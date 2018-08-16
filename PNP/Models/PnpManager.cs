using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNP.Models
{
    public class PnpManager
    {
        [Key]
        public int pnpManID { get; set; }
        [Display(Name = "Name")]
        public string pnpManName { get; set; }
        [Display(Name = "Surname")]
        public string pnpManSurname { get; set; }
        [Display(Name = "Email")]
        public string pnpManEmail { get; set; }
        [Display(Name = "Password")]
        public string pnpManPassword { get; set; }

        public ICollection<PnpSales> Sales { get; set; }
    }
}
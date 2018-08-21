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
        public int PnpManID { get; set; }
        [Display(Name = "Name")]
        public string PnpManName { get; set; }
        [Display(Name = "Surname")]
        public string PnpManSurname { get; set; }
        [Display(Name = "Email")]
        public string PnpManEmail { get; set; }
        [Display(Name = "Password")]
        public string PnpManPassword { get; set; }

        public ICollection<PnpSales> Sales { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNP.Models
{
    public class PnpEmployee
    {

        [Key]
        public int PnpEmpID { get; set; }

        [Display(Name = "Name")]
        public string PnpEmpName { get; set; }
        [Display(Name = "Surname")]
        public string PnpEmpSurname { get; set; }
        [Display(Name = "Email")]
        public string PnpEmpEmail { get; set; }
        [Display(Name = "Password")]
        public string PnpPassword { get; set; }
        [Display(Name = "Gender")]
        public string PnpEmpGender { get; set; }
        [Display(Name = "Date")]
        public DateTime PnpDateTime { get; set; }

        public ICollection<PnpSales> Sales { get; set; }

    }
}
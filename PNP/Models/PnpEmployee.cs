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
        public int pnpEmpID { get; set; }

        [Display(Name = "Name")]
        public string pnpEmpName { get; set; }
        [Display(Name = "Surname")]
        public string pnpEmpSurname { get; set; }
        [Display(Name = "Email")]
        public string pnpEmpEmail { get; set; }
        [Display(Name = "Password")]
        public string pnpPassword { get; set; }
        [Display(Name = "Gender")]
        public string pnpEmpGender { get; set; }
        [Display(Name = "Date")]
        public DateTime pnpDateTime { get; set; }

    }
}
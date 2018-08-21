using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAR.Models
{
    public class SparEmployee
    {

        [Key]
        public int sparEmpID { get; set; }

        [Display(Name = "Name")]
        public string sparEmpName { get; set; }
        [Display(Name = "Surname")]
        public string sparEmpSurname { get; set; }
        [Display(Name = "Email")]
        public string sparEmpEmail { get; set; }
        [Display(Name = "Password")]
        public string sparPassword { get; set; }
        [Display(Name = "Gender")]
        public string sparEmpGender { get; set; }
        [Display(Name = "Date")]
        public DateTime sparDateTime { get; set; }
    }
}
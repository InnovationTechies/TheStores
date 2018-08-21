using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAR.Models
{
    public class SparManager
    {
        [Key]
        public int sparManID { get; set; }
        [Display(Name = "Name")]
        public string sparManName { get; set; }
        [Display(Name = "Surname")]
        public string sparManSurname { get; set; }
        [Display(Name = "Email")]
        public string sparManEmail { get; set; }
        [Display(Name = "Password")]
        public string sparManPassword { get; set; }



    }
}
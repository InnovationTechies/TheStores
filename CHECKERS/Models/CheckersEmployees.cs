using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CHECKERS.Models
{
    public class CheckersEmployees
    {

        [Key]
        public int CheckersEmpID { get; set; }

        [Display(Name = "Name")]
        public string CheckersEmpName { get; set; }
        [Display(Name = "Surname")]
        public string CheckersEmpSurname { get; set; }
        [Display(Name = "Email")]
        public string CheckersEmpEmail { get; set; }
        [Display(Name = "Password")]
        public string CheckersPassword { get; set; }
        [Display(Name = "Gender")]
        public string CheckersEmpGender { get; set; }
        [Display(Name = "Date")]
        public DateTime CheckersDateTime { get; set; }

        public ICollection<CheckersSales> Sales { get; set; }
    }
}
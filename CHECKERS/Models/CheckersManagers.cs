using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CHECKERS.Models
{
    public class CheckersManagers
    {
        [Key]
        public int CheckersManID { get; set; }
        [Display(Name = "Name")]
        public string CheckersManName { get; set; }
        [Display(Name = "Surname")]
        public string CheckersManSurname { get; set; }
        [Display(Name = "Email")]
        public string CheckersManEmail { get; set; }
        [Display(Name = "Password")]
        public string CheckersManPassword { get; set; }

        public ICollection<CheckersSales> Sales { get; set; }
    }
}
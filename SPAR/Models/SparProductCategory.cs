using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAR.Models
{
    public class SparProductCategory
    {
        [Key]
        public int CategoryID { get; set; }
        [Display(Name = "Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }
        
    }
}
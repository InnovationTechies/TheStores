using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAR.Models
{
    public class SparSales
    {
        [Key]
        public int sparSalesID { get; set; }
        public List<SparEmployee> employees { get; set; }
        public List<SparLocation> locations { get; set; }
        public List<SparManager> managers { get; set; }
        public List<SparSpecial> specials { get; set; }
        public List<SparProducts> products { get; set; }

    }
}
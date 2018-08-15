using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNP.Models
{
    public class PnpSales
    {
        [Key]
        public int PnpSalesID { get; set; }
        public List<PnpEmployee> employees { get; set; }
        public List<PnpLocation> locations { get; set; }
        public List<PnpManager> managers { get; set; }
        public List<PnpSpecial> specials { get; set; }
        public List<Products> products { get; set; }



    }
}
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

        public IEnumerable<PnpEmployee> employees { get; set; }
        public IEnumerable<PnpLocation> locations { get; set; }
        public IEnumerable<PnpManager> managers { get; set; }
        public IEnumerable<PnpSpecial> specials { get; set; }
        public IEnumerable<Products> products { get; set; }

    }
}
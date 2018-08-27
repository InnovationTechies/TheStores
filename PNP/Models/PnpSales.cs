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
        //Fkeys
        public PnpEmployee Employee { get; set; }
        public PnpLocation Location { get; set; }
        public PnpManager Manager { get; set; }
        public PnpSpecial Special { get; set; }
        public PnpProducts Products{ get; set; }

    }
}
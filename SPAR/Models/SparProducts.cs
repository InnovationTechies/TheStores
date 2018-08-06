using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAR.Models
{
    public class SparProducts
    {
        [Key]
        public int productID { get; set; }
        public string productName { get; set; }
        public string productImage { get; set; }
        public double productPrice { get; set; }
        public double productDropPercent { get; set; }
        public string productDescription { get; set; }
        public DateTime productDateEndPromo { get; set; }
        public IEnumerable<SparProductCategory > ProductCategory { get; set; }
    }
}
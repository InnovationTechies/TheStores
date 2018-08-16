using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNP.Models
{
    public class PnpProducts
    {
        [Key]
        public int productID { get; set; }

        [Display(Name = "Name")]
        public string productName { get; set; }
        [Display(Name = "Price")]
        public float productPrice { get; set; }
        [Display(Name = "Image")]
        public string productImage { get; set; }
        [Display(Name = "Percent")]
        public double productDropPercent { get; set; }
        [Display(Name = "Description")]
        public string productDesc { get; set; }
        [Display(Name = "Special End Date")]
        public DateTime productDateEndPromo { get; set; }
        [Display(Name = "Catagory")]
        //public IEnumerable<ProductCatagory> productCatagories { get; set; }

        public ProductCatagory Catagory { get; set; }

        public ICollection<PnpSales> Sales { get; set; }

        //public List<ProductCatagory> productCatagoy { get; set; }




    }
}
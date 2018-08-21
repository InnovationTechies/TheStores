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
        public int ProductID { get; set; }

        [Display(Name = "Name")]
        public string ProductName { get; set; }
        [Display(Name = "Price")]
        public float ProductPrice { get; set; }
        [Display(Name = "Image")]
        public string ProductImage { get; set; }
        [Display(Name = "Percent")]
        public double ProductDropPercent { get; set; }
        [Display(Name = "Description")]
        public string ProductDesc { get; set; }
        [Display(Name = "Special End Date")]
        public DateTime ProductDateEndPromo { get; set; }
        [Display(Name = "Catagory")]
        //public IEnumerable<ProductCatagory> productCatagories { get; set; }

        public ProductCatagory Catagory { get; set; }

        public ICollection<PnpSales> Sales { get; set; }

        //public List<ProductCatagory> productCatagoy { get; set; }




    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHECKERS.Models
{
    public class ProductCategory
    {
        [Key]
        public int catagoryID { get; set; }
        public string catagoryName { get; set; }
        public string catagoryDesc { get; set; }
    }
}
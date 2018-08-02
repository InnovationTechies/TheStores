﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNP.Models
{
    public class ProductCatagory
    {
        [Key]
        public int catagoryID { get; set; }
        public string catagoryName { get; set; }
        public string catagoryDesc { get; set; }
    }
}
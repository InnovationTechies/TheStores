using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PNP.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PNPContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PNPContext() : base("name=PNPContext")
        {
        }

        public System.Data.Entity.DbSet<PNP.Models.Products> Products { get; set; }
    }
}

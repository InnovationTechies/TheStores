using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CHECKERS.Models
{
    public class CheckersSales
    {
        [Key]
        public int CheckersSalesID { get; set; }

        //public IEnumerable<CheckersEmployee> employees { get; set; }
        //public IEnumerable<CheckersLocation> locations { get; set; }
        //public IEnumerable<CheckersManager> managers { get; set; }
        //public IEnumerable<CheckersSpecial> specials { get; set; }
        //public IEnumerable<Products> products { get; set; }


        /// <summary>
        /// Foriegn Keys
        /// </summary>
        public CheckersEmployees Employee { get; set; }
        public CheckersLocation Location { get; set; }
        public CheckersManagers Manager { get; set; }
        public CheckersSpecials Special { get; set; }
        public Products Products { get; set; }

    }
}
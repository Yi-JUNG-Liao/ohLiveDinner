using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class ProductInfo
    {
        public string MenuID { get; set; }
        public string MenuName { get; set; }
        public decimal Price { get; set; }
        public int UnitStock { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Picture { get; set; }

    }
}
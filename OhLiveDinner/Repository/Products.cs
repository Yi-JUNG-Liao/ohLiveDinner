using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Models
{
    public class Products
    {
        public int MealID { get; set; }
        public string MealName { get; set; }
        public decimal MealPrice { get; set; }
        public string MealCategory { get; set; }
        public int MealQuantity { get; set; }
        public int MealStatus { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Models
{
    public class Meal
    {
        public int MealID { get; set; }
        public string MealName { get; set; }
        public decimal MealPrice { get; set; }
        public string MealCategory { get; set; }
        public int MealQuantity { get; set; }
        public int MealStatus { get; set; }
    }
}
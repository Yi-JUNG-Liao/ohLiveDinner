using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Project.Models;

namespace MVC_Project.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<appetizer> Appetizer { get; set; }
        public IEnumerable<desert> Desert { get; set; }
        public IEnumerable<drink> Drink { get; set; }
        public IEnumerable<main> Main { get; set; }
    }
}
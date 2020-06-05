using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Models.ViewModels.Product
{
    public class Product_GetAll_OutputModel
    {
        public int ProductId { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductIntroduction { get; set; }

        public string ProductImage { get; set; }
    }
}
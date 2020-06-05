using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Models.DatabaseEntityModels
{
    public class ShoppingCar_Product
    {
        public int ProductId { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductIntroduction { get; set; }

        public string ProductImage { get; set; }

        public int ProductKindId { get; set; }

        public int ProductStatusId { get; set; }

        public int ShoppingCarId { get; set; }

        public int MemberId { get; set; }

        public int ProductQuantity{get;set;}
    }
}
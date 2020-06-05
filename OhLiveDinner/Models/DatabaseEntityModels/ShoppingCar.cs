using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Models.DatabaseEntityModels
{
    public class ShoppingCar
    {
        public int ShoppingCarId { get; set; }
        public int MemberId { get; set; }

        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
}
    }
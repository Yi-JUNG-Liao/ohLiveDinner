using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Models.ViewModels.Product
{
    public class ShoppingCar_GetAll_OutputModel
    {
        public int ShoppingCaId { get; set; }
        public int MemberId { get; set; }
        

        public int ProductId { get; set; }
        public int ProductQuantityId { get; set; }
      
    }
}
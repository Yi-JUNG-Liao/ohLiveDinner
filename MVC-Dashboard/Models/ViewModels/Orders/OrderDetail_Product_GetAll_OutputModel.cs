using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Models.ViewModels.Orders
{
    public class OrderDetail_Product_GetAll_OutputModel
    {
        public int ProductId { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public int ProductKindId { get; set; }

        public int ProductStatusId { get; set; }



        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        //public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int ProductQuantity { get; set; }
        public float OrderDiscount { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Models.ViewModels
{
    public class Product_ProductStatus_OutputModel
    {
        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int ProductKindId { get; set; }
        public int ProductStatusId { get; set; }
        public string ProductStatusName { get; set; }
    }
}
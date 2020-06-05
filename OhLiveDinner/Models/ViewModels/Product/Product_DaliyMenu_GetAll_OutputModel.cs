﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Models.ViewModels.Product_DaliyMenu
{
    public class Product_DaliyMenu_GetAll_OutputModel
    {
        public int ProductId { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductIntroduction { get; set; }

        public string ProductImage { get; set; }

        public int ProductKindId { get; set; }

        public int ProductStatusId { get; set; }

        public int DaliyMenuId { get; set; }

        public int Week { get; set; }
    }
}
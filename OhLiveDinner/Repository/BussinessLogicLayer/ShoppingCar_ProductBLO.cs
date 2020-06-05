
using OhLiveDinner.Models.ViewModels.Product;
using OhLiveDinner.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Repository.BussinessLogicLayer
{
    public class ShoppingCar_ProductBLO
    {
        private ShoppingCar_ProductDAO _ShoppingCar_ProductDAO;

        public ShoppingCar_ProductBLO()
        {
            _ShoppingCar_ProductDAO = new ShoppingCar_ProductDAO();
        }

        public List<ShoppingCar_Product_GetAll_OutputModel> GetAll()
        {
            List<ShoppingCar_Product_GetAll_OutputModel> result;

            var queryresult = _ShoppingCar_ProductDAO.GetAll();

            result = queryresult.Select(x => new ShoppingCar_Product_GetAll_OutputModel
            {
                ProductId = x.ProductId,
                ProductIntroduction = x.ProductIntroduction,
                ProductPrice = x.ProductPrice,
                ProductImage = x.ProductImage,
                ProductKindId = x.ProductKindId,
                ProductStatusId = x.ProductStatusId,
                MemberId = x.MemberId,
                ProductQuantity = x.ProductQuantity,
                ShoppingCarId = x.ProductStatusId
            }).ToList();

            return result;
        }
    }
}
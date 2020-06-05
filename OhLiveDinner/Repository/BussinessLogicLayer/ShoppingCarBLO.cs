using OhLiveDinner.Models.OutUnitModels;
using OhLiveDinner.Models.ViewModels.Product;
using OhLiveDinner.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Repository.BussinessLogicLayer
{
    public class ShoppingCarBLO
    {
        private ShoppingCarDAO _ShoppingCarDAO;

        public ShoppingCarBLO()
        {
            _ShoppingCarDAO = new ShoppingCarDAO();
        }

        public List<ShoppingCar_Product_GetAll_OutputModel> GetShoppingCarProduct()
        {
            List<ShoppingCar_Product_GetAll_OutputModel> result;

            var queryresult = _ShoppingCarDAO.GetShoppingCarProduct();

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

        public List<ShoppingCar_GetAll_OutputModel> GetAllShoppingCar()
        {
            List<ShoppingCar_GetAll_OutputModel> result;

            var queryresult = _ShoppingCarDAO.GetAllShoppingCar();

            result = queryresult.Select(x => new ShoppingCar_GetAll_OutputModel
            {
                ShoppingCaId = x.ShoppingCarId,
                MemberId = x.MemberId,
                ProductId = x.ProductId,
                ProductQuantityId = x.ProductQuantity
            }).ToList();

            return result;
        }
    }
}
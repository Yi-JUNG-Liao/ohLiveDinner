using OhLiveDinner.Models.ViewModels.Product;
using OhLiveDinner.Models.ViewModels.Product_DaliyMenu;
using OhLiveDinner.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Repository.BussinessLogicLayer
{
    public class ProductBLO
    {
        private ProductDAO _ProductDAO;

        public ProductBLO()
        {
            _ProductDAO = new ProductDAO();
        }

        public List<Product_GetAll_OutputModel> GetAll()
        {
            List<Product_GetAll_OutputModel> result;

            var queryresult = _ProductDAO.GetAll();

            result = queryresult.Select(x => new Product_GetAll_OutputModel
            {
                ProductId = x.ProductId,
                ProductIntroduction = x.ProductIntroduction,
                ProductPrice = x.ProductPrice,
                ProductImage = x.ProductImage,
                ProductKindName = x.ProductKindName
            }).ToList();

            return result;
        }

        public List<Product_DaliyMenu_GetAll_OutputModel> GetProductDaliyMenu()
        {
            List<Product_DaliyMenu_GetAll_OutputModel> result;

            var queryresult = _ProductDAO.GetProductDaliyMenu();

            result = queryresult.Select(x => new Product_DaliyMenu_GetAll_OutputModel
            {
                ProductId = x.ProductId,
                ProductIntroduction = x.ProductIntroduction,
                ProductPrice = x.ProductPrice,
                ProductImage = x.ProductImage,
                Week = x.Week
            }).ToList();

            return result;
        }
    }
}
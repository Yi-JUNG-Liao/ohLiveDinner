using MVC_Dashboard.Models.ViewModels;
using MVC_Dashboard.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Repository.BussinessLogicLayer
{
    public class ProductBLO
    {
        private ProductDAO _ProductDAO;

        public ProductBLO()
        {
            _ProductDAO = new ProductDAO();
        }

        public List<Product_GetAll_OutputModel> GetAllProduct()
        {
            List<Product_GetAll_OutputModel> result;

            var queryresult = _ProductDAO.GetAllProduct();


            result = queryresult.Select(x => new Product_GetAll_OutputModel
            {
                ProductId =x.ProductId,
                ProductImage = x.ProductImage,
                ProductName = x.ProductName,
                ProductPrice =x.ProductPrice,
                ProductKindId=x.ProductKindId,
                ProductStatusId=x.ProductStatusId

            }).ToList();

            return result;
        }

        public List<Product_ProductStatus_OutputModel> GetProductPS()
        {
            List<Product_ProductStatus_OutputModel> result;

            var queryresult = _ProductDAO.GetProductPS();


            result = queryresult.Select(x => new Product_ProductStatus_OutputModel

            {
                ProductId = x.ProductId,
                ProductImage = x.ProductImage,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductKindId = x.ProductKindId,
                ProductStatusId = x.ProductStatusId,
                ProductStatusName = x.ProductStatusName

            }).ToList();

            return result;
        }

        public List<Product_PSPK_OutputModel> GetProductPSPK()
        {
            List<Product_PSPK_OutputModel> result;
            
                var queryresult = _ProductDAO.GetProductPSPK();

            


            result = queryresult.Select(x => new Product_PSPK_OutputModel

            {
                ProductId = x.ProductId,
                ProductImage = x.ProductImage,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductKindId = x.ProductKindId,
                ProductStatusId = x.ProductStatusId,
                ProductStatusName = x.ProductStatusName,
                ProductKindName = x.ProductKindName

            }).ToList();

            return result;
        }
    }
}
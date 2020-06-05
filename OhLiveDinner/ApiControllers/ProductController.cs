using OhLiveDinner.Models.OutUnitModels;
using OhLiveDinner.Repository.BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OhLiveDinner.ApiControllers
{
    public class ProductController : ApiController
    {
        private ProductBLO _ProductBLO = new ProductBLO();
        private ShoppingCar_ProductBLO _ShoppingCar_ProductBLO = new ShoppingCar_ProductBLO();

        public ProductController()
        {
            _ProductBLO = new ProductBLO();
            _ShoppingCar_ProductBLO = new ShoppingCar_ProductBLO();
        }
         

        [HttpGet]
        public OutApiModel GetAllProduct()
        {
            try
            {
                

                var queryresult = _ProductBLO.GetAll();

                OutApiModel result = new OutApiModel(APIStatusCode.OK, queryresult, string.Empty);

                return result;
            }
            catch(Exception ex)
            {
                OutApiModel result = new OutApiModel(APIStatusCode.Fail, null, "Error");

                return result;
            }
        }

        [HttpGet]
        public OutApiModel GetProductDaliyMenu()

        {
            try
            {
                var queryresult = _ProductBLO.GetProductDaliyMenu();

                OutApiModel result = new OutApiModel(APIStatusCode.OK, queryresult, string.Empty);

                return result;
            }
            catch (Exception ex)
            {
                OutApiModel result = new OutApiModel(APIStatusCode.Fail, null, "Error");

                return result;
            }
        }


    }
}

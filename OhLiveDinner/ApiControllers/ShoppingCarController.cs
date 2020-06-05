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
    public class ShoppingCarController : ApiController
    {
        private ShoppingCarBLO _ShoppingCarBLO = new ShoppingCarBLO();

        public ShoppingCarController()
        {
            _ShoppingCarBLO = new ShoppingCarBLO();
        }

        [HttpGet]
        public OutApiModel GetAllShoppingCarProduct()
        {
            try
            {
                var queryresult = _ShoppingCarBLO.GetShoppingCarProduct();

                OutApiModel result = new OutApiModel(APIStatusCode.OK, queryresult, string.Empty);

                return result;
            }
            catch (Exception ex)
            {
                OutApiModel result = new OutApiModel(APIStatusCode.Fail, null, "Error");

                return result;
            }
        }

        [HttpGet]
        public OutApiModel GetAllShoppingCar()
        {
            try
            {


                var queryresult = _ShoppingCarBLO.GetAllShoppingCar();

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

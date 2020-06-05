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
    public class OrderController : ApiController
    {
        private OrderBLO _OrderBLO = new OrderBLO();

        public OrderController()
        {
            _OrderBLO = new OrderBLO();
        }

        [HttpGet]
        public OutApiModel GetAllOrder()
        {
            try
            {


                var queryresult = _OrderBLO.GetAllOrder();

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

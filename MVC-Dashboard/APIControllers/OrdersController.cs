using MVC_Dashboard.Models.OutUnitModels;
using MVC_Dashboard.Repository.BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Dashboard.APIControllers
{
    public class OrdersController : ApiController
    {
        private OrderBLO _OrderBLO = new OrderBLO();

        public OrdersController()
        {
            _OrderBLO = new OrderBLO();
        }

        [HttpGet]
        public OutApiModel GetAllOrders()
        {
            try
            {

                var queryresult = _OrderBLO.GetAllOrders();

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
        public OutApiModel GetAllOrderDetailProduct()
        {
            try
            {

                var queryresult = _OrderBLO.GetAllOrderDetailProduct();

                OutApiModel result = new OutApiModel(APIStatusCode.OK, queryresult, string.Empty);

                return result;
            }
            catch (Exception ex)
            {
                OutApiModel result = new OutApiModel(APIStatusCode.Fail, null, "Error");

                return result;
            }
        }

        public OutApiModel GetAllOrdersOrderStatus()
        {
            try
            {

                var queryresult = _OrderBLO.GetAllOrdersOrderStatus();

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

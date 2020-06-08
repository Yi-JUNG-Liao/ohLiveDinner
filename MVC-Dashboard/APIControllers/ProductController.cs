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
    public class ProductController : ApiController
    {
        private ProductBLO _ProductBLO = new ProductBLO();

        public ProductController()
        {
            _ProductBLO = new ProductBLO();
        }

        [HttpGet]
        public OutApiModel GetAllProduct()
        {
            try
            {
                var queryresult = _ProductBLO.GetAllProduct();

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
        public OutApiModel GetProductPS()
        {
            try
            {
                var queryresult = _ProductBLO.GetProductPS();

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
        public OutApiModel GetProductPSPK()
        {
            try
            {
                var queryresult = _ProductBLO.GetProductPSPK();

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

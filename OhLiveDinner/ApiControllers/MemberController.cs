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
    public class MemberController : ApiController
    {
        private MemberBLO _MemberBLO = new MemberBLO();
        private Member_Order_OrderStatus_OrderPaymentBLO _Member_Order_OrderStatus_OrderPaymentBLO = new Member_Order_OrderStatus_OrderPaymentBLO();

        
        public MemberController()
        {
            _MemberBLO = new MemberBLO();
            _Member_Order_OrderStatus_OrderPaymentBLO = new Member_Order_OrderStatus_OrderPaymentBLO();
        }

        [HttpGet]
        public OutApiModel GetAllMember()
        {
            try
            {


                var queryresult = _MemberBLO.GetAllMember();

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
        public OutApiModel GetAllMOOO()
        {
            try
            {


                var queryresult = _MemberBLO.GetAllMOOO();

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

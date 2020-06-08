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
    public class MemberController : ApiController
    {
        private MemberBLO _MemberBLO = new MemberBLO();

        public MemberController()
        {
            _MemberBLO = new MemberBLO();
        }

        [HttpGet]
        public OutApiModel GetAllMemberData()
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
    }
}

using MVC_Dashboard.Models.ViewModels;
using MVC_Dashboard.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Repository.BussinessLogicLayer
{
    public class MemberBLO
    {
        private MemberDAO _MemberDAO;

        public MemberBLO()
        {
            _MemberDAO = new MemberDAO();
        }

        public List<Member_GetAll_OutputModel> GetAllMember()
        {
            List<Member_GetAll_OutputModel> result;

            var queryresult = _MemberDAO.GetAllMember();


            result = queryresult.Select(x => new Member_GetAll_OutputModel
            {
                MemberId = x.MemberId,
                MemberEmail = x.MemberEmail,
                MemberAddress = x.MemberAddress,
                MemberLoginTime = x.MemberLoginTime,
                MemberName = x.MemberName,
                MemberPassword = x.MemberPassword,
                MemberPhone = x.MemberPhone
                
            }).ToList();

            return result;
        }
    }
}
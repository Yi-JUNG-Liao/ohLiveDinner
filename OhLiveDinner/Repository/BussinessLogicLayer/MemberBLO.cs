using OhLiveDinner.Models.ViewModels.Member;
using OhLiveDinner.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Repository.BussinessLogicLayer
{
    public class MemberBLO
    {
        private MemberDAO _MemberDAO;

        public MemberBLO()
        {
            _MemberDAO = new MemberDAO();
        }

        public List<Member_GetAll_OutModel> GetAllMember()
        {
            List<Member_GetAll_OutModel> result;

            var queryresult = _MemberDAO.GetAllMember();


            result = queryresult.Select(x => new Member_GetAll_OutModel
            {
                MemberId= x.MemberId,
                MemberEmail = x.MemberEmail,
                MemberAddress = x.MemberAddress,
                MemberLoginTime = x.MemberLoginTime,
                MemberName=x.MemberName,
                MemberPassword=x.MemberPassword,
                MemberPhone=x.MemberPhone
            }).ToList();

            return result;
        }

        public List<Member_Order_OrderStatus_OrderPayment_GetAll_OutputModel> GetAllMOOO()
        {
            List<Member_Order_OrderStatus_OrderPayment_GetAll_OutputModel> result;

            var queryresult = _MemberDAO.GetAllMOOO();

            result = queryresult.Select(x => new Member_Order_OrderStatus_OrderPayment_GetAll_OutputModel
            {
                OrderId = x.OrderId,
                MemberId = x.MemberId,
                OrderPaymentId = x.OrderPaymentId,
                OrderpaymentName = x.OrderpaymentName,
                OrderStatusId = x.OrderStatusId,
                OrderStatusName = x.OrderStatusName,
                OrderStartTime = x.OrderStartTime,
                OrderEndTime = x.OrderEndTime
            }).ToList();

            return result;
        }

    }
}
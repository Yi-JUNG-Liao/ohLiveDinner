using OhLiveDinner.Models.ViewModels.Member;
using OhLiveDinner.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Repository.BussinessLogicLayer
{
    public class Member_Order_OrderStatus_OrderPaymentBLO
    {
        private Member_Order_OrderStatus_OrderPaymentDAO _Member_Order_OrderStatus_OrderPaymentDAO;

        public Member_Order_OrderStatus_OrderPaymentBLO()
        {
            _Member_Order_OrderStatus_OrderPaymentDAO = new Member_Order_OrderStatus_OrderPaymentDAO();
        }

        public List<Member_Order_OrderStatus_OrderPayment_GetAll_OutputModel> GetAllMOOO()
        {
            List<Member_Order_OrderStatus_OrderPayment_GetAll_OutputModel> result;

            var queryresult = _Member_Order_OrderStatus_OrderPaymentDAO.GetAllMOOO();

            result = queryresult.Select(x => new Member_Order_OrderStatus_OrderPayment_GetAll_OutputModel
            {
                OrderId=x.OrderId,
                MemberId=x.MemberId,
                OrderPaymentId=x.OrderPaymentId,
                OrderpaymentName=x.OrderpaymentName,
                OrderStatusId=x.OrderStatusId,
                OrderStatusName=x.OrderStatusName,
                OrderStartTime=x.OrderStartTime,
                OrderEndTime=x.OrderEndTime
            }).ToList();

            return result;
        }
    }
}
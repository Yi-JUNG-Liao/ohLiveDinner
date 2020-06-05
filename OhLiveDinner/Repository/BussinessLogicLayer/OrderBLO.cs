using OhLiveDinner.Models.ViewModels.Product;
using OhLiveDinner.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Repository.BussinessLogicLayer
{
    public class OrderBLO
    {
        private OrderDAO _OrderDAO;

        public OrderBLO()
        {
            _OrderDAO = new OrderDAO();
        }

        public List<Order_GetAll_OutputModel> GetAllOrder()
        {
            List<Order_GetAll_OutputModel> result;

            var queryresult = _OrderDAO.GetAllOrder();

            result = queryresult.Select(x => new Order_GetAll_OutputModel
            {
                OrderId = x.OrderId,
                OrderTotalPrice = x.OrderTotalPrice,
                OrderPayMethod = x.OrderPayMethod,
                MemberId = x.MemberId,
                OrderStatusId = x.OrderStatusId,
                OrderEvaluation=x.OrderEvaluation,
                OrderEndTime = x.OrderEndTime,
                OrderStartTime = x.OrderStartTime
            }).ToList();

            return result;
        }
    }
}
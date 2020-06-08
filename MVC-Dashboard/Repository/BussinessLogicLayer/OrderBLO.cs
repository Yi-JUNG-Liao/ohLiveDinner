using MVC_Dashboard.Models.DatabaseEntityModels;
using MVC_Dashboard.Models.ViewModels.Orders;
using MVC_Dashboard.Repository.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Repository.BussinessLogicLayer
{
    public class OrderBLO
    {
        private OrderDAO _OrderDAO;

        public OrderBLO()
        {
            _OrderDAO = new OrderDAO();        
        }

        public List<Orders_GetAll_OutputModel> GetAllOrders()
        {
            List<Orders_GetAll_OutputModel> result;

            var queryresult = _OrderDAO.GetAllOrders();

            result = queryresult.Select(x => new Orders_GetAll_OutputModel
            {      
                OrderId = x.OrderId,
                OrderTotalPrice = x.OrderTotalPrice,
                OrderPayMethod = x.OrderPayMethod,
                MemberId = x.MemberId,
                OrderStatusId = x.OrderStatusId,
                OrderEvaluation = x.OrderEvaluation,
                OrderEndTime = x.OrderEndTime,
                OrderStartTime = x.OrderStartTime
            }).ToList();

            return result;
        }


        public List<OrderDetail_Product_GetAll_OutputModel> GetAllOrderDetailProduct()
        {
            List<OrderDetail_Product_GetAll_OutputModel> result;

            var queryresult = _OrderDAO.GetAllOrderDetailProduct();

            result = queryresult.Select(x => new OrderDetail_Product_GetAll_OutputModel
            {
                ProductId = x.ProductId,
                ProductPrice = x.ProductPrice,
                ProductStatusId = x.ProductStatusId,
                ProductImage = x.ProductImage,
                ProductKindId = x.ProductKindId,
                ProductName = x.ProductName,
                OrderDetailId = x.OrderDetailId,
                OrderId = x.OrderId,
                UnitPrice = x.UnitPrice,
                ProductQuantity = x.ProductQuantity,
                OrderDiscount = x.OrderDiscount
            }).ToList();

            return result;
        }


        public List<Orders_OrderStatus_GetAll_OutputModel> GetAllOrdersOrderStatus()
        {
            List<Orders_OrderStatus_GetAll_OutputModel> result;

            var queryresult = _OrderDAO.GetAllOrdersOrderStatus();

            result = queryresult.Select(x => new Orders_OrderStatus_GetAll_OutputModel
            {
                OrderId = x.OrderId,
                OrderTotalPrice = x.OrderTotalPrice,
                OrderPayMethod = x.OrderPayMethod,
                MemberId = x.MemberId,
                OrderStatusId = x.OrderStatusId,
                OrderEvaluation = x.OrderEvaluation,
                OrderEndTime = x.OrderEndTime,
                OrderStartTime = x.OrderStartTime,
                OrderStatusName = x.OrderStatusName
            }).ToList();

            return result;
        }
    }
}
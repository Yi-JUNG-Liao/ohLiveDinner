using MVC_Dashboard.Models.DatabaseEntityModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace MVC_Dashboard.Repository.DatabaseAccessLayer
{
    public class OrderDAO
    {
        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["OhLiveDB"].ConnectionString;

        public IEnumerable<Orders> GetAllOrders()
        {
            string SQLcommand = @"SELECT * FROM Orders";

            IEnumerable<Orders> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Orders>(SQLcommand);
            }

            return result;
        }

        public IEnumerable<OrderDetail_Product> GetAllOrderDetailProduct()
        {
            string SQLcommand = @"select * from OrderDetail od
                                    inner join Product p
                                    on od.ProductId=p.ProductId";

            IEnumerable<OrderDetail_Product> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<OrderDetail_Product>(SQLcommand);
            }

            return result;
        }

        public IEnumerable<Orders_OrderStatus> GetAllOrdersOrderStatus()
        {
            string SQLcommand = @"select * from Orders o
                                inner join OrderStatus os
                                on o.OrderStatusId = os.OrderStatusId";

            IEnumerable<Orders_OrderStatus> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Orders_OrderStatus>(SQLcommand);
            }

            return result;
        }
    }
}
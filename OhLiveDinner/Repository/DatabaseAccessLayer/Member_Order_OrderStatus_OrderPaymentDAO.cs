using Dapper;
using OhLiveDinner.Models.DatabaseEntityModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Repository.DatabaseAccessLayer
{
    public class Member_Order_OrderStatus_OrderPaymentDAO
    {
        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["OhLiveDB"].ConnectionString;

        public IEnumerable<Member_Order_OrderStatus_OrderPayment> GetAllMOOO()
        {
            string SQLcommand = @"  SELECT * 
                                    FROM Member m  
                                    inner join [Order] o on o.MemberId=m.MemberId
                                    inner join OrderStatus os on os.OrderStatusId=o.OrderStatusId
                                    inner join OrderPayment op on op.OrderpaymentId=o.OrderpaymentId";

            IEnumerable<Member_Order_OrderStatus_OrderPayment> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Member_Order_OrderStatus_OrderPayment>(SQLcommand);
            }

            return result;
        }
    }
}
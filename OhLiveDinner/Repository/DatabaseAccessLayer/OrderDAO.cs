using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using OhLiveDinner.Models.DatabaseEntityModels;

namespace OhLiveDinner.Repository.DatabaseAccessLayer
{
    public class OrderDAO
    {

        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["OhLiveDB"].ConnectionString;

        public IEnumerable<Orders> GetAllOrder()
        {
            string SQLcommand = @"SELECT * FROM Orders";

            IEnumerable<Orders> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Orders>(SQLcommand);
            }

            return result;
        }
    }
}
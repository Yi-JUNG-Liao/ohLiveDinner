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
    public class ShoppingCar_ProductDAO
    {
        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["OhLiveDB"].ConnectionString;

        public IEnumerable<ShoppingCar_Product> GetAll()
        {
            string SQLcommand = @"SELECT * FROM Product p inner join ShoppingCar s on p.ProductId = s.ProductId";

            IEnumerable<ShoppingCar_Product> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<ShoppingCar_Product>(SQLcommand);
            }

            return result;
        }
    }
}
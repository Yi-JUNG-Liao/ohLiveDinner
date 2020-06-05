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
    public class ShoppingCarDAO
    {
        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["OhLiveDB"].ConnectionString;

        public IEnumerable<ShoppingCar_Product> GetShoppingCarProduct()
        {
            string SQLcommand = @"SELECT * FROM Product p inner join ShoppingCar s on p.ProductId = s.ProductId";

            IEnumerable<ShoppingCar_Product> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<ShoppingCar_Product>(SQLcommand);
            }

            return result;
        }

        public IEnumerable<ShoppingCar> GetAllShoppingCar()
        {
            string SQLcommand = @"SELECT * FROM ShoppingCar";

            IEnumerable<ShoppingCar> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<ShoppingCar>(SQLcommand);
            }

            return result;
        }
    }
}
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
    public class ProductDAO
    {
        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["OhLiveDB"].ConnectionString;

        public IEnumerable<Product> GetAll()
        {
            string SQLcommand = @"SELECT * FROM Product
 inner join ProductKind p on p.ProductKindId = Product.ProductKindId";

            IEnumerable<Product> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Product>(SQLcommand);
            }

            return result;
        }

        public IEnumerable<Product_DaliyMenu> GetProductDaliyMenu()
        {
            string SQLcommand = @"SELECT * FROM Product p inner join DaliyMenu dm on p.ProductId = dm.ProductId";

            IEnumerable<Product_DaliyMenu> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Product_DaliyMenu>(SQLcommand);
            }

            return result;
        }
    }
}
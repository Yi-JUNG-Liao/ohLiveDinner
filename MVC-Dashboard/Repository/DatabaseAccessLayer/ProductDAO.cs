using Dapper;
using MVC_Dashboard.Models.DatabaseEntityModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Repository.DatabaseAccessLayer
{
    public class ProductDAO
    {
        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["OhLiveDB"].ConnectionString;

        public IEnumerable<Product> GetAllProduct()
        {
            string SQLcommand = @"SELECT * FROM Product";

            IEnumerable<Product> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Product>(SQLcommand);
            }

            return result;
        }

        public IEnumerable<Product_ProductStatus> GetProductPS()
        {
            string SQLcommand = @"SELECT * FROM Product p 
                                inner join ProductStatus ps on p.ProductStatusId= ps.ProductStatusId";

            IEnumerable<Product_ProductStatus> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Product_ProductStatus>(SQLcommand);
            }

            return result;
        }

        public IEnumerable<Product_PS_PK> GetProductPSPK()
        {
            string SQLcommand = @"SELECT * 
                                    FROM Product p 
                                    inner join ProductStatus ps on p.ProductStatusId= ps.ProductStatusId
                                    inner join ProductKind pk on p.ProductKindId = pk.ProductKindId";

            IEnumerable<Product_PS_PK> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Product_PS_PK>(SQLcommand);
            }

            return result;
        }


    }
}
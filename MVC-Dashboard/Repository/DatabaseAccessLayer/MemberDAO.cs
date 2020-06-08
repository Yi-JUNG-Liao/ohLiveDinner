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
    public class MemberDAO
    {
        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["OhLiveDB"].ConnectionString;

        public IEnumerable<Member> GetAllMember()
        {
            string SQLcommand = @"SELECT * FROM Member";

            IEnumerable<Member> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Member>(SQLcommand);
            }

            return result;
        }
    }
}
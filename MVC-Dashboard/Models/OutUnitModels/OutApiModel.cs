using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Models.OutUnitModels
{
    public class OutApiModel
    {
        public OutApiModel(string statuscode, object result, string errormsg)
        {
            StatusCode = statuscode;
            Result = result;
            ErrorMsg = errormsg;
        }

        public string StatusCode { get; set; }
        public string ErrorMsg { get; set; }
        public object Result { get; set; }
    }

    public static class APIStatusCode {
        public static string OK = "1";
        public static string Fail = "2";
    }
}
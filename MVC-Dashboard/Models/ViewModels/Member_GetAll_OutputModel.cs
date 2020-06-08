using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Models.ViewModels
{
    public class Member_GetAll_OutputModel
    {
        
        public int MemberId { get; set; }
        public string MemberEmail { get; set; }

        public string MemberPassword { get; set; }

        public string MemberAddress { get; set; }

        public string MemberName { get; set; }

        public string MemberPhone { get; set; }

        public string MemberLoginTime { get; set; }
    }
}
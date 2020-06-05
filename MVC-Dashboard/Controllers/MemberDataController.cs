using MVC_Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Dashboard.ViewModel;

namespace MVC_Dashboard.Controllers
{
    public class MemberDataController : Controller
    {
        private MVC_DashboardContext db = new MVC_DashboardContext();

        // GET: MemberData
        public ActionResult Index()
        {
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrdersList()
        {
            return View();
        }
        public ActionResult OrdersStatus()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductsList()
        {
            return View();
        }

        public ActionResult ProductAdd()
        {
            return View();
        }
        public ActionResult ProductUpdate()
        {
            return View();
        }
    }
}
using MVC_Project.Models;
using MVC_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class ProductsListController : Controller
    {
        // GET: ProductsList
        public ActionResult Products()
        {
            List<appetizer> products = new List<appetizer>
            {
                new appetizer {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/appetizer1.jpg" },
                 new appetizer {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/appetizer2.jpg" },
                  new appetizer {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/appetizer3.jpg" }

            };

            List<main> mainproducts = new List<main>
            {
                new main {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/main1.jpg" },
                 new main {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/main2.jpg" },
                  new main {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/main3.jpg" }

            };
            List<desert> desert = new List<desert>
            {
                new desert {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/desert1.jpg" },
                 new desert {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/desert2.jpg" },
                  new desert {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/desert3.jpg" }

            };
            List<drink> drink = new List<drink>
            {
                new drink {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/drink1.jpg" },
                 new drink {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/drink2.jpg" },
                  new drink {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/drink3.jpg" }

            };

            ProductsViewModel productsViewModel = new ProductsViewModel();

            productsViewModel.Appetizer = products;
            productsViewModel.Main = mainproducts;
            productsViewModel.Desert = desert;
            productsViewModel.Drink = drink;




            return View(productsViewModel);
        }


        public ActionResult monday()
        {
            List<appetizer> products = new List<appetizer>
            {
                new appetizer {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/appetizer1.jpg" },
                 new appetizer {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/appetizer2.jpg" },
                  new appetizer {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/appetizer3.jpg" }

            };

            List<main> mainproducts = new List<main>
            {
                new main {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/main1.jpg" },
                 new main {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/main2.jpg" },
                  new main {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/main3.jpg" }

            };
            List<desert> desert = new List<desert>
            {
                new desert {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/desert1.jpg" },
                 new desert {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/desert2.jpg" },
                  new desert {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/desert3.jpg" }

            };
            List<drink> drink = new List<drink>
            {
                new drink {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/drink1.jpg" },
                 new drink {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/drink2.jpg" },
                  new drink {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/drink3.jpg" }

            };

            ProductsViewModel productsViewModel = new ProductsViewModel();

            productsViewModel.Appetizer = products;
            productsViewModel.Main = mainproducts;
            productsViewModel.Desert = desert;
            productsViewModel.Drink = drink;




            return View(productsViewModel);
        }
        public ActionResult tuesday()
        {
            List<appetizer> products = new List<appetizer>
            {
                new appetizer {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/appetizer1.jpg" },
                 new appetizer {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/appetizer2.jpg" },
                  new appetizer {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/appetizer3.jpg" }

            };

            List<main> mainproducts = new List<main>
            {
                new main {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/main1.jpg" },
                 new main {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/main2.jpg" },
                  new main {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/main3.jpg" }

            };
            List<desert> desert = new List<desert>
            {
                new desert {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/desert1.jpg" },
                 new desert {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/desert2.jpg" },
                  new desert {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/desert3.jpg" }

            };
            List<drink> drink = new List<drink>
            {
                new drink {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/drink1.jpg" },
                 new drink {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/drink2.jpg" },
                  new drink {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/drink3.jpg" }

            };

            ProductsViewModel productsViewModel = new ProductsViewModel();

            productsViewModel.Appetizer = products;
            productsViewModel.Main = mainproducts;
            productsViewModel.Desert = desert;
            productsViewModel.Drink = drink;




            return View(productsViewModel);
        }
        public ActionResult wedsday()
        {
            List<appetizer> products = new List<appetizer>
            {
                new appetizer {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/appetizer1.jpg" },
                 new appetizer {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/appetizer2.jpg" },
                  new appetizer {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/appetizer3.jpg" }

            };

            List<main> mainproducts = new List<main>
            {
                new main {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/main1.jpg" },
                 new main {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/main2.jpg" },
                  new main {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/main3.jpg" }

            };
            List<desert> desert = new List<desert>
            {
                new desert {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/desert1.jpg" },
                 new desert {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/desert2.jpg" },
                  new desert {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/desert3.jpg" }

            };
            List<drink> drink = new List<drink>
            {
                new drink {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/drink1.jpg" },
                 new drink {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/drink2.jpg" },
                  new drink {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/drink3.jpg" }

            };

            ProductsViewModel productsViewModel = new ProductsViewModel();

            productsViewModel.Appetizer = products;
            productsViewModel.Main = mainproducts;
            productsViewModel.Desert = desert;
            productsViewModel.Drink = drink;




            return View(productsViewModel);
        }
        public ActionResult thrusday()
        {
            List<appetizer> products = new List<appetizer>
            {
                new appetizer {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/appetizer1.jpg" },
                 new appetizer {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/appetizer2.jpg" },
                  new appetizer {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/appetizer3.jpg" }

            };

            List<main> mainproducts = new List<main>
            {
                new main {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/main1.jpg" },
                 new main {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/main2.jpg" },
                  new main {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/main3.jpg" }

            };
            List<desert> desert = new List<desert>
            {
                new desert {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/desert1.jpg" },
                 new desert {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/desert2.jpg" },
                  new desert {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/desert3.jpg" }

            };
            List<drink> drink = new List<drink>
            {
                new drink {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/drink1.jpg" },
                 new drink {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/drink2.jpg" },
                  new drink {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/drink3.jpg" }

            };

            ProductsViewModel productsViewModel = new ProductsViewModel();

            productsViewModel.Appetizer = products;
            productsViewModel.Main = mainproducts;
            productsViewModel.Desert = desert;
            productsViewModel.Drink = drink;




            return View(productsViewModel);
        }
        public ActionResult friday()
        {
            List<appetizer> products = new List<appetizer>
            {
                new appetizer {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/appetizer1.jpg" },
                 new appetizer {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/appetizer2.jpg" },
                  new appetizer {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/appetizer3.jpg" }

            };

            List<main> mainproducts = new List<main>
            {
                new main {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/main1.jpg" },
                 new main {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/main2.jpg" },
                  new main {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/main3.jpg" }

            };
            List<desert> desert = new List<desert>
            {
                new desert {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/desert1.jpg" },
                 new desert {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/desert2.jpg" },
                  new desert {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/desert3.jpg" }

            };
            List<drink> drink = new List<drink>
            {
                new drink {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/drink1.jpg" },
                 new drink {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/drink2.jpg" },
                  new drink {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/drink3.jpg" }

            };

            ProductsViewModel productsViewModel = new ProductsViewModel();

            productsViewModel.Appetizer = products;
            productsViewModel.Main = mainproducts;
            productsViewModel.Desert = desert;
            productsViewModel.Drink = drink;




            return View(productsViewModel);
        }
        public ActionResult saturday()
        {
            List<appetizer> products = new List<appetizer>
            {
                new appetizer {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/appetizer1.jpg" },
                 new appetizer {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/appetizer2.jpg" },
                  new appetizer {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/appetizer3.jpg" }

            };

            List<main> mainproducts = new List<main>
            {
                new main {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/main1.jpg" },
                 new main {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/main2.jpg" },
                  new main {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/main3.jpg" }

            };
            List<desert> desert = new List<desert>
            {
                new desert {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/desert1.jpg" },
                 new desert {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/desert2.jpg" },
                  new desert {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/desert3.jpg" }

            };
            List<drink> drink = new List<drink>
            {
                new drink {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/drink1.jpg" },
                 new drink {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/drink2.jpg" },
                  new drink {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/drink3.jpg" }

            };

            ProductsViewModel productsViewModel = new ProductsViewModel();

            productsViewModel.Appetizer = products;
            productsViewModel.Main = mainproducts;
            productsViewModel.Desert = desert;
            productsViewModel.Drink = drink;




            return View(productsViewModel);
        }
        public ActionResult sunday()
        {
            List<appetizer> products = new List<appetizer>
            {
                new appetizer {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/appetizer1.jpg" },
                 new appetizer {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/appetizer2.jpg" },
                  new appetizer {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/appetizer3.jpg" }

            };

            List<main> mainproducts = new List<main>
            {
                new main {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/main1.jpg" },
                 new main {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/main2.jpg" },
                  new main {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/main3.jpg" }

            };
            List<desert> desert = new List<desert>
            {
                new desert {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/desert1.jpg" },
                 new desert {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/desert2.jpg" },
                  new desert {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/desert3.jpg" }

            };
            List<drink> drink = new List<drink>
            {
                new drink {MealID=1,MealName="123",MealPrice=1234,MealPicture="/Assets/images/foodimages/drink1.jpg" },
                 new drink {MealID=2,MealName="1573",MealPrice=8676,MealPicture="/Assets/images/foodimages/drink2.jpg" },
                  new drink {MealID=3,MealName="1788",MealPrice=457,MealPicture="/Assets/images/foodimages/drink3.jpg" }

            };

            ProductsViewModel productsViewModel = new ProductsViewModel();

            productsViewModel.Appetizer = products;
            productsViewModel.Main = mainproducts;
            productsViewModel.Desert = desert;
            productsViewModel.Drink = drink;




            return View(productsViewModel);
        }
    }
}
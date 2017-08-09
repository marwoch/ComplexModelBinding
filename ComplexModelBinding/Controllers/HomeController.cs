using ComplexModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplexModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //get an order
            //get order cartItems
            Order order1 = GetOrder();            
            
            //pass data to view            
            return View(order1);
        }

        private Order GetOrder()
        {
            return new Order()
            {
                OrderId = 1,
                CustomerId = 100,
                Date = DateTime.Now,
                Total = 150,
                CartItems = GetCartItems()
            };
        }

        private List<CartItem> GetCartItems()
        {
                CartItem item1 = new CartItem()
                {
                    ProductId = 5,
                    Quantity = 10
                };

                CartItem item2 = new CartItem()
                {
                    ProductId = 4000,
                    Quantity = 50
                };

               return new List<CartItem>()
                { item1, item2 };
        }
  
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
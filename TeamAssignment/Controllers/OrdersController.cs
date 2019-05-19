using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamAssignment.Data;
using TeamAssignment.Models;

namespace TeamAssignment.Controllers
{
    public class OrdersController : Controller
    {

        private IOrderRepository repository;
        private ShoppingCart cart;
        public OrdersController(IOrderRepository repoService, ShoppingCart cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        // GET: Orders
        public ActionResult Index()
        {
            return View(new Order() { Purchases = cart });
        }

        // GET: Orders
        public ActionResult History()
        {
            return View(repository.Orders.ToList());
        }

        // Post: Orders/Checkout
        public RedirectToActionResult Checkout(Order order)
        {
            order.Purchases = cart;
            repository.SaveOrder(order);
            cart.CleanCart();
            return RedirectToAction("CheckoutComplete");
        }        

        // GET: Orders/CheckoutComplete
        public ActionResult CheckoutComplete()
        {
            return View();
        }
    }
}

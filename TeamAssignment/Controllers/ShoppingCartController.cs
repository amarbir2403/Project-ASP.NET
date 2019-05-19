using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamAssignment.Models;

namespace TeamAssignment.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IBoardGameRepository repository;

        private ShoppingCart cart;

        public ShoppingCartController(IBoardGameRepository repo, ShoppingCart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View(cart);
        }

        // POST: ShoppingCart/Add
        public RedirectToActionResult Add(int ProductId, int ItemQuantity)
        {
            var Product = repository.BoardGames.Where(p => p.Id == ProductId).FirstOrDefault();

            cart.AddItem(Product, ItemQuantity);
            return RedirectToAction("Index");
        }

        // GET: ShoppingCart/CleanCart
        public RedirectToActionResult CleanCart()
        {
            cart.CleanCart();
            return RedirectToAction("Index");
        }

        // GET: ShoppingCart/Delete/5
        public RedirectToActionResult Delete(int ProductId)
        {
            var Product = repository.BoardGames.Where(p => p.Id == ProductId).FirstOrDefault();

            cart.RemoveItem(Product);
            return RedirectToAction("Index");
        }
    }
}
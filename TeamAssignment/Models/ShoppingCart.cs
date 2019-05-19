using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamAssignment.Models
{
    public class CartItem
    {
        // Primary key
        public int Id { get; set; }

        // The game we are buying
        public BoardGame PurchasedGame { get; set; }

        // How many copies we bought
        public int Quantity { get; set; }

        // The total price for this Item (cost of item * how many we bought)
        [NotMapped]
        public double CartTotal { get { return Quantity * PurchasedGame.Price; } }
    }

    public class ShoppingCart
    {
        // Primary keys
        public int Id { get; set; }

        // The list of items
        public List<CartItem> PurchasedGames = new List<CartItem>();

        // Add an item to the cart
        virtual public void AddItem(BoardGame Item, int ItemQuantity)
        {

            CartItem DBItem = PurchasedGames.Where(g => g.PurchasedGame.Id == Item.Id).FirstOrDefault();

            // If we don't have the item in our list it's a new item
            if (DBItem == null)
                PurchasedGames.Add(new CartItem { PurchasedGame = Item, Quantity = ItemQuantity });
            // Otherwise we added quantity to an item
            else
                DBItem.Quantity += ItemQuantity;
        }

        // Remove an item to the cart
        virtual public void RemoveItem(BoardGame Item)
        {
            CartItem DBItem = PurchasedGames.Where(g => g.PurchasedGame.Id == Item.Id).FirstOrDefault();

            if (DBItem != null)
                PurchasedGames.Remove(DBItem);
        }

        // Remove all items from the cart
        virtual public void CleanCart()
        {
            PurchasedGames.Clear();
        }

        // The cart total
        [NotMapped]
        public double CartTotal { get { return PurchasedGames.Sum(c => c.CartTotal); } }
    }
}

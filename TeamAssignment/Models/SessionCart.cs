using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using TeamAssignment.Infrastructure;

namespace TeamAssignment.Models
{
    public class SessionCart : ShoppingCart
    {
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(BoardGame Item, int ItemQuantity)
        {
            base.AddItem(Item, ItemQuantity);
            Session.SetJson("Cart", this);
        }
        public override void RemoveItem(BoardGame Item)
        {
            base.RemoveItem(Item);
            Session.SetJson("Cart", this);
        }
        public override void CleanCart()
        {
            base.CleanCart();
            Session.Remove("Cart");
        }
    }
}

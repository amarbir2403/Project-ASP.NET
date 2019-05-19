using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamAssignment.Models;

namespace TeamAssignment.Data
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;
        public EFOrderRepository(ApplicationDbContext ctx) { context = ctx; }
        public IQueryable<Order> Orders => context.Orders.Include(o => o.Purchases).ThenInclude(p => p.PurchasedGames);

        public void SaveOrder(Order order)
        {
            context.Attach(order.Purchases);

            if (order.Id == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
}
}

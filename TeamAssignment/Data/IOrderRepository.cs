using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamAssignment.Models;

namespace TeamAssignment.Data
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVersta.Models
{
    public class EFOrders : IAbstractOrders
    {
        private readonly AppDBContext context;
        public EFOrders(AppDBContext context) => this.context = context;

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await context.Orders.ToListAsync();
        }

        public async Task SaveOrder(Order order)
        {
            if (order.Id == default)
                context.Entry(order).State = EntityState.Added;
            else
                context.Entry(order).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}

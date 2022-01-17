using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVersta.Models
{
    public interface IAbstractOrders
    {
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task SaveOrder(Order order);
    }
}

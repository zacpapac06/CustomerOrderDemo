using Customers.api.Data;
using Customers.api.Models;
using Microsoft.EntityFrameworkCore;

namespace Customers.api.Repositories
{
    public class OrderRepository:Repository<Order>,IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        // Custom query to get orders by customer ID
        public async Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(int customerId)
        {
            return await context.Orders
                                 .Where(o => o.CustomerId == customerId)
                                 .Include(o => o.Items)
                                 .ThenInclude(i => i.Product)
                                 .ToListAsync();
        }
    }
}

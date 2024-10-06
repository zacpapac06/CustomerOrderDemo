using Customers.api.Models;

namespace Customers.api.Repositories
{
    public interface IOrderRepository: IRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(int customerId);
    }
}

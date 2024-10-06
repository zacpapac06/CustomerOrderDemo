using Customers.api.Models;

namespace Customers.api.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<IEnumerable<Customer>> GetCustomersWithOrdersAsync();
    }
}

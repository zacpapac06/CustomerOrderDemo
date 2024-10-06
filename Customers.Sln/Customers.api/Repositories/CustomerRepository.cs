using Customers.api.Data;
using Customers.api.Models;
using Microsoft.EntityFrameworkCore;

namespace Customers.api.Repositories
{
    public class CustomerRepository:Repository<Customer>,ICustomerRepository
    {
        
        public CustomerRepository(AppDbContext context):base(context)
        {
        }
        // Custom query to get customers with their related orders
        public async Task<IEnumerable<Customer>> GetCustomersWithOrdersAsync()
        {
            return await context.Customers.Include(c => c.Orders).ToListAsync();
        }
    }
}

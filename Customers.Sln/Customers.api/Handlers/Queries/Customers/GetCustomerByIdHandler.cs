using Customers.api.Models;
using Customers.api.Queries.Customers;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Queries.Customers
{
    /// <summary>
    /// This Handler retrieves a customer by their CustomerId
    /// </summary>
    public class GetCustomerByIdHandler
    {
        private readonly ICustomerRepository customerRepository;

        public GetCustomerByIdHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(GetCustomerByIdQuery query)
        {
            return await customerRepository.GetByIdAsync(query.CustomerId);
        }
    }
}

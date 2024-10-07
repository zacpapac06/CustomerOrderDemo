using Customers.api.Models;
using Customers.api.Queries.Customers;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Queries.Customers
{
    public class GetAllCustomersHandler
    {
        private readonly ICustomerRepository customerRepository;

        public GetAllCustomersHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> Handle(GetAllCustomersQuery query)
        {
            return await customerRepository.GetAllAsync();
        }
    }
}

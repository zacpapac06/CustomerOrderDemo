using Customers.api.Commands.Customers;
using Customers.api.Models;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Commands.Customers
{
    /// <summary>
    /// Handler uses the ICustomerRepository to add a new customer to the database
    /// </summary>
    public class CreateCustomerHandler
    {
        private readonly ICustomerRepository customerRepository;

        public CreateCustomerHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task Handle(CreateCustomerCommand command)
        {
            var customer = new Customer
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Address = command.Address,
                PostalCode = command.PostalCode
            };

            await customerRepository.AddAsync(customer);
            await customerRepository.SaveChangesAsync();
        }
    }
}

using Customers.api.Commands.Customers;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Commands.Customers
{
    /// <summary>
    /// Handler based on customerID, updates details, and saves the changes.
    /// </summary>
    public class UpdateCustomerHandler
    {
        private readonly ICustomerRepository customerRepository;

        public UpdateCustomerHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task Handle(UpdateCustomerCommand command)
        {
            var customer = await customerRepository.GetByIdAsync(command.CustomerId);

            if (customer == null)
            {
                throw new ArgumentException($"Customer with ID {command.CustomerId} not found.");
            }

            customer.FirstName = command.FirstName;
            customer.LastName = command.LastName;
            customer.Address = command.Address;
            customer.PostalCode = command.PostalCode;

            customerRepository.Update(customer);
            
            await customerRepository.SaveChangesAsync();
        }
    }
}

using Customers.api.Commands.Customers;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Commands.Customers
{
    /// <summary>
    /// Handler deletes based on customerID after verifying their existence in the database.
    /// </summary>
    public class DeleteCustomerHandler
    {
        private readonly ICustomerRepository customerRepository;

        public DeleteCustomerHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task Handle(DeleteCustomerCommand command)
        {
            var customer = await customerRepository.GetByIdAsync(command.CustomerId);

            if (customer == null)
            {
                throw new ArgumentException($"Customer with ID {command.CustomerId} not found.");
            }

            customerRepository.Delete(customer);
            
            await customerRepository.SaveChangesAsync();
        }
    }
}

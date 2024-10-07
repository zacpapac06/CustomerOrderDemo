using Customers.api.Commands.Customers;
using Customers.api.Dtos;
using Customers.api.Models;
using Customers.api.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Customers.api.Handlers.Commands.Customers
{
    /// <summary>
    /// Handler uses the ICustomerRepository to add a new customer to the database
    /// </summary>
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository customerRepository;

        public CreateCustomerHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        //public async Task<CustomerDto> Handle(CreateCustomerCommand command)
        //{
        //    var customer = new Customer
        //    {
        //        FirstName = command.FirstName,
        //        LastName = command.LastName,
        //        Address = command.Address,
        //        PostalCode = command.PostalCode
        //    };

        //    await customerRepository.AddAsync(customer);
        //    await customerRepository.SaveChangesAsync();


        //    return new CustomerDto
        //    {
        //        Id = customer.Id,
        //        FirstName = customer.FirstName,
        //        LastName = customer.LastName,
        //        Address = customer.Address,
        //        PostalCode = customer.PostalCode
        //    };
        //}

        public async Task<CustomerDto> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
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


            return new CustomerDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                PostalCode = customer.PostalCode
            };
        }
    }
}

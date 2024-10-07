using Customers.api.Dtos;
using MediatR;

namespace Customers.api.Commands.Customers
{
    public class CreateCustomerCommand:IRequest<CustomerDto>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public CreateCustomerCommand(string firstName, string lastName, string address, string postalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PostalCode = postalCode;
        }
    }
}

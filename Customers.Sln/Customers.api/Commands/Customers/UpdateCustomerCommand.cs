namespace Customers.api.Commands.Customers
{
    public class UpdateCustomerCommand
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public UpdateCustomerCommand(int customerId, string firstName, string lastName, string address, string postalCode)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PostalCode = postalCode;
        }
    }
}

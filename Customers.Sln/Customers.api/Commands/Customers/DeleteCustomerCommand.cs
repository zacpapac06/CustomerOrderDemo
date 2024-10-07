namespace Customers.api.Commands.Customers
{
    public class DeleteCustomerCommand
    {
        public int CustomerId { get; set; }

        public DeleteCustomerCommand(int customerId)
        {
            CustomerId = customerId;
        }
    }
}

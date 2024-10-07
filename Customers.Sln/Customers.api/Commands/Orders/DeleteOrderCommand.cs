namespace Customers.api.Commands.Orders
{
    public class DeleteOrderCommand
    {
        public int OrderId { get; set; }

        public DeleteOrderCommand(int orderId)
        {
            OrderId = orderId;
        }
    }
}

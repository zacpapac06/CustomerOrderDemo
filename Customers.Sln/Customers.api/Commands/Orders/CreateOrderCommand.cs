using Customers.api.Dtos;

namespace Customers.api.Commands.Orders
{
    public class CreateOrderCommand
    {
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }

        public CreateOrderCommand(int customerId, List<OrderItemDto> orderItems, DateTime orderDate)
        {
            CustomerId = customerId;
            OrderItems = orderItems;
            OrderDate = orderDate;
        }
    }
}

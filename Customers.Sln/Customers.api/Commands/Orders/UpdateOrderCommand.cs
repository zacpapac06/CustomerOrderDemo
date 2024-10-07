using Customers.api.Dtos;

namespace Customers.api.Commands.Orders
{
    public class UpdateOrderCommand
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }

        public UpdateOrderCommand(int orderId, List<OrderItemDto> orderItems, DateTime orderDate)
        {
            OrderId = orderId;
            OrderItems = orderItems;
            OrderDate = orderDate;
        }

    }
}

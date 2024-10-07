using Customers.api.Commands.Orders;
using Customers.api.Models;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Commands.Orders
{
    /// <summary>
    /// Handler updates an existing order with new data.
    /// </summary>
    public class UpdateOrderHandler
    {
        private readonly IOrderRepository orderRepository;

        public UpdateOrderHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task Handle(UpdateOrderCommand command)
        {
            var order = await orderRepository.GetByIdAsync(command.OrderId);

            if (order == null)
            {
                throw new ArgumentException($"Order with ID {command.OrderId} not found.");
            }

            order.OrderDate = command.OrderDate;
            order.Items = new List<Item>();

            foreach (var item in command.OrderItems)
            {
                order.Items.Add(new Item
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Order = order
                });
            }

            orderRepository.Update(order);
            
            await orderRepository.SaveChangesAsync();
        }
    }
}

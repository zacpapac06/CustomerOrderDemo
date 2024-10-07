using Customers.api.Commands.Orders;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Commands.Orders
{
    /// <summary>
    /// Handler deletes an order by its OrderId
    /// </summary>
    public class DeleteOrderHandler
    {
        private readonly IOrderRepository orderRepository;

        public DeleteOrderHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task Handle(DeleteOrderCommand command)
        {
            var order = await orderRepository.GetByIdAsync(command.OrderId);

            if (order == null)
            {
                throw new ArgumentException($"Order with ID {command.OrderId} not found.");
            }

            orderRepository.Delete(order);
            
            await orderRepository.SaveChangesAsync();
        }

    }
}

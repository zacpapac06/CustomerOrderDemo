using Customers.api.Commands.Orders;
using Customers.api.Models;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Commands.Orders
{
    /// <summary>
    /// This handler creates a new order for a given customer and order items.
    /// </summary>
    public class CreateOrderHandler
    {
        private readonly IOrderRepository orderRepository;
        private readonly ICustomerRepository customerRepository;

        public CreateOrderHandler(IOrderRepository orderRepository, ICustomerRepository customerRepository)
        {
            this.orderRepository = orderRepository;
            this.customerRepository = customerRepository;
        }

        public async Task Handle(CreateOrderCommand command)
        {
            // Check if the customer exists
            var customer = await customerRepository.GetByIdAsync(command.CustomerId);

            if (customer == null)
            {
                throw new ArgumentException($"Customer with ID {command.CustomerId} not found.");
            }

            var order = new Order
            {
                CustomerId = command.CustomerId,
                OrderDate = command.OrderDate,
                Items = new List<Item>()
            };
            // Process the order items and add them to the order

            foreach (var item in command.OrderItems)
            {
                order.Items.Add(new Item
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Order = order
                });
            }

            await orderRepository.AddAsync(order);
            
            await orderRepository.SaveChangesAsync();
        }
    }
}

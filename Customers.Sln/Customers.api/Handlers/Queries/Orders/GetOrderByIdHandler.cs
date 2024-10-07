using Customers.api.Models;
using Customers.api.Queries.Orders;
using Customers.api.Repositories;

namespace Customers.api.Handlers.Queries.Orders
{
    public class GetOrderByIdHandler
    {
        private readonly IOrderRepository orderRepository;

        public GetOrderByIdHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task<Order> Handle(GetOrderByIdQuery query)
        {
            return await orderRepository.GetByIdAsync(query.OrderId);
        }
    }
}

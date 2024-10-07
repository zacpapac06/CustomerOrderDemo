﻿namespace Customers.api.Queries.Orders
{
    public class GetOrderByIdQuery
    {
        public int OrderId { get; set; }

        public GetOrderByIdQuery(int orderId)
        {
            OrderId = orderId;
        }
    }
}

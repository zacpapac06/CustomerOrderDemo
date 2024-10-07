namespace Customers.api.Queries.Orders
{
    /// <summary>
    /// This query retrieves all orders associated with a specific customer.
    /// </summary>
    public class GetOrdersByCustomerIdQuery
    {
        public int CustomerId { get; set; }

        public GetOrdersByCustomerIdQuery(int customerId)
        {
            CustomerId = customerId;
        }
    }
}

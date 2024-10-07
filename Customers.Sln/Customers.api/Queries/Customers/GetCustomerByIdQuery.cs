namespace Customers.api.Queries.Customers
{
    /// <summary>
    /// This query retrieves a customer based on CustomerId
    /// </summary>
    public class GetCustomerByIdQuery
    {
        public int CustomerId { get; set; }

        public GetCustomerByIdQuery(int customerId)
        {
            CustomerId = customerId;
        }
    }
}

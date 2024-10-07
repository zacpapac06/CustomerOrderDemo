namespace Customers.api.Queries.Orders
{
    /// <summary>
    /// This query retrieves all orders within a specified date range.
    /// </summary>
    public class GetOrdersByDateRangeQuery
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public GetOrdersByDateRangeQuery(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}

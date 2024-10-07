using Customers.api.Models;
using MediatR;

namespace Customers.api.Queries.Orders
{
    /// <summary>
    /// This query retrieves all orders within a specified date range.
    /// </summary>
    public class GetOrdersByDateRangeQuery: IRequest<IEnumerable<Order>>
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

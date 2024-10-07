using Customers.api.Dtos;
using MediatR;

namespace Customers.api.Queries.Customers
{
    /// <summary>
    /// This query retrieves all customers.
    /// </summary>
    public class GetAllCustomersQuery:IRequest<List<CustomerDto>>
    {

    }
}

using AutoMapper;
using Customers.api.Dtos;
using Customers.api.Models;
using Customers.api.Queries.Customers;
using Customers.api.Repositories;
using MediatR;

namespace Customers.api.Handlers.Queries.Customers
{
    public class GetAllCustomersHandler: IRequestHandler<GetAllCustomersQuery, List<CustomerDto>>
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IMapper mapper;
        public GetAllCustomersHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            this.customerRepository = customerRepository;
            this.mapper = mapper;
        }

        //public async Task<IEnumerable<Customer>> Handle(GetAllCustomersQuery query)
        //{
        //    return await customerRepository.GetAllAsync();
        //}

        public async Task<List<CustomerDto>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await customerRepository.GetAllAsync();
            
            return mapper.Map<List<CustomerDto>>(customers);
        }
    }
}

using AutoMapper;
using Customers.api.Dtos;
using Customers.api.Models;

namespace Customers.api.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}

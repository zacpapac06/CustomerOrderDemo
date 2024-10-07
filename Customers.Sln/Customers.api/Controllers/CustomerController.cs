using Customers.api.Commands.Customers;
using Customers.api.Queries.Customers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customers.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator mediator;

        public CustomerController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET api/customers/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await mediator.Send(new GetCustomerByIdQuery(id));
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }


        // POST api/customers
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerCommand command)
        {
            var result = await mediator.Send(command);

            return CreatedAtAction(nameof(GetCustomerById), new { id = result.Id}, result);  // Returns 201 Created response
        }


        // PUT api/customers/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] UpdateCustomerCommand command)
        {
            if (id != command.CustomerId)
            {
                return BadRequest();
            }

            var result = await mediator.Send(command);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // DELETE api/customers/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var result = await mediator.Send(new DeleteCustomerCommand(id));
            
            if (result is null)
            {
                return NotFound();
            }
            
            return NoContent();  // Returns 204 No Content if deletion is successful
        }

        // GET api/customers
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await mediator.Send(new GetAllCustomersQuery());
            
            return Ok(customers);
        }
    }
}

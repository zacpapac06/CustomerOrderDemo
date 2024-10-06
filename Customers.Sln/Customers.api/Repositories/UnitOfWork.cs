using Customers.api.Data;

namespace Customers.api.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public ICustomerRepository Customers { get; private set; }
        public IOrderRepository Orders { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
            Customers = new CustomerRepository(this.context);
            Orders = new OrderRepository(this.context);
        }

        public async Task<bool> CompleteAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }

}

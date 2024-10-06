namespace Customers.api.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        Task<bool> CompleteAsync();
    }
}

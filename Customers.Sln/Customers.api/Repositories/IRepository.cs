namespace Customers.api.Repositories
{
    public interface IRepository<T> where T : class
    {
        //Retrieves an entity by its ID
        Task<T?> GetByIdAsync(int id);
        //Retrieves all entities.
        Task<IEnumerable<T>> GetAllAsync();
        //Adds a new entity
        Task AddAsync(T entity);
        //Updates an existing entity
        void Update(T entity);
        //Deletes an entity
        void Delete(T entity);
        //Saves all changes made to the database
        Task<bool> SaveChangesAsync();
    }
}

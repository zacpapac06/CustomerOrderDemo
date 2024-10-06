namespace Customers.api.Models
{
    public class Product
    {
        // Unique identifier, cannot be null.
        public int Id { get; set; }

        // Name must have a value.
        public string Name { get; set; } = null!;
        
        // Price must have a value.
        public decimal Price { get; set; }  
    }
}

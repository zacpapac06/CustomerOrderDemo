namespace Customers.api.Models
{
    public class Item
    {
        // Unique identifier, cannot be null.
        public int Id { get; set; }
        
        // Quantity must be non-null (cannot order a null quantity).
        public int Quantity { get; set; }

        // Foreign key to Product, cannot be null.
        public int ProductId { get; set; }
        
        // Navigation property for the Product, must always have a value.
        public Product Product { get; set; } = null!;

        // Foreign key to Order, cannot be null
        public int OrderId { get; set; }

        // Navigation property for the Order, must always have a value.
        public Order Order { get; set; } = null!;
    }
}

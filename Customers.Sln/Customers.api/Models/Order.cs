namespace Customers.api.Models
{
    public class Order
    {
        // Unique identifier, cannot be null.
        public int Id { get; set; }

        // Order date cannot be null.
        public DateTime OrderDate { get; set; }
        
        // Total price cannot be null.
        public decimal TotalPrice { get; set; }

        // One-to-many relationship with Items
        // Items list should never be null, but can be empty.
        public List<Item> Items { get; set; } = new List<Item>();

        // Foreign key to Customer, cannot be null.
        public int CustomerId { get; set; }

        // Navigation property for the Customer, must always have a value.
        public Customer Customer { get; set; } = null!;
    }
}

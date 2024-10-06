namespace Customers.api.Models
{
    public class Customer
    {
        // Unique identifier, cannot be null.
        public int Id { get; set; }  
        
        // First name must have a value.
        public string FirstName { get; set; } = null!;  

        // Last name must have a value.
        public string LastName { get; set; } = null!;  
        
        // Address must have a value.
        public string Address { get; set; } = null!;  

        // Postal code must have a value.
        public string PostalCode { get; set; } = null!;  

        // One-to-many relationship with Orders
        // Orders list should never be null, but can be empty.
        public List<Order> Orders { get; set; } = new List<Order>();  
    }
}

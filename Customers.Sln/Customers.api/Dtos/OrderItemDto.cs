namespace Customers.api.Dtos
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public OrderItemDto(int productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}

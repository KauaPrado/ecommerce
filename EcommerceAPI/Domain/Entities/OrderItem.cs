namespace EcommerceAPI.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public Guid ProductId { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public Guid OrderId { get; private set; } // Relacionamento com o Pedido

        protected OrderItem() { }

        public OrderItem(Guid productId, decimal unitPrice, int quantity)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
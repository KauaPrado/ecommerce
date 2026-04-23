using EcommerceAPI.Domain.Enums;

namespace EcommerceAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; private set; }
        public OrderStatus Status { get; private set; }
        public decimal TotalAmount { get; private set; }

        private readonly List<OrderItem> _items;
        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();

        protected Order() { _items = new List<OrderItem>(); }

        public Order(Guid customerId)
        {
            CustomerId = customerId;
            Status = OrderStatus.PendingPayment;
            _items = new List<OrderItem>();
        }
    }
}
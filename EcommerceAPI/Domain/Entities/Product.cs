namespace EcommerceAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public decimal WeightKg { get; private set; }
        public int StockQuantity { get; private set; }

        protected Product() { } 

        public Product(string name, string description, decimal price, decimal weightKg, int initialStock)
        {
            Name = name;
            Description = description;
            Price = price;
            WeightKg = weightKg;
            StockQuantity = initialStock;
        }
    }
}
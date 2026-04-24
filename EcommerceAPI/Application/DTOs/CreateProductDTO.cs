namespace EcommerceAPI.Application.DTOs
{
    public class CreateProductDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal WeightKg { get; set; }
        public int StockQuantity { get; set; }
    }
}
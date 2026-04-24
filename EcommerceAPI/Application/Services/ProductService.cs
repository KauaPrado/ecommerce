using EcommerceAPI.Application.DTOs;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Domain.Interfaces;

namespace EcommerceAPI.Application.Services
{

    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product> CreateProductAsync(CreateProductDTO dto)
        {
            // O Service converte o DTO burro em uma Entidade Rica de Domínio
            var product = new Product(
                dto.Name,
                dto.Description,
                dto.Price,
                dto.WeightKg,
                dto.StockQuantity
            );

            await _repository.AddAsync(product);

            return product;
        }
    }
}
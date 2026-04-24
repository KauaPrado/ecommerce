using EcommerceAPI.Application.DTOs;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Domain.Interfaces;

namespace EcommerceAPI.Application.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> CreateProductAsync(CreateProductDTO dto);
    }

}
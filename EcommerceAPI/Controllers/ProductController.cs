using EcommerceAPI.Application.DTOs;
using EcommerceAPI.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        // Injetando a Interface do Serviço (A Mágica do .NET!)
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDTO request)
        {
            // O Controller apenas repassa o DTO para o Service cuidar da regra de negócio
            var product = await _productService.CreateProductAsync(request);

            // Retorna o status 201 (Criado com Sucesso) e o objeto que foi salvo
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}
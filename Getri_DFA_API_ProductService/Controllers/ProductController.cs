using AutoMapper;
using Getri_DFA_API_ProductService.DTO;
using Getri_DFA_API_ProductService.Models;
using Getri_DFA_API_ProductService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Getri_DFA_API_ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository iproductRepository;
        private readonly IMapper mapper;

        public ProductController(IProductRepository _iproductRepository, IMapper _mapper)
        {
            iproductRepository = _iproductRepository;
            mapper = _mapper;
        }

        [HttpGet("ProductList")]
        public IActionResult GetProducts()
        {
            var products = iproductRepository.GetProducts().ToList();
            return Ok(products);
        }

        [HttpGet("SearchProduct")]
        public IActionResult SearchProduct(int id)
        {
            var product = iproductRepository.SearchProduct(id);
            if (product == null)
            {
                return NotFound("The product record couldn't be found.");
            }
            return Ok(product);
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return BadRequest("Product is null.");
            }
            var createdProduct = iproductRepository.CreateProduct(mapper.Map<Product>(productDTO));
            return Ok(createdProduct);
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(UpdateProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return BadRequest("Product is null.");
            }
            var updatedProduct = iproductRepository.UpdateProduct(mapper.Map<Product>(productDTO));
            return Ok(updatedProduct);
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(DeleteProductDTO deleteProductDTO)
        {
            var product = iproductRepository.SearchProduct(deleteProductDTO.Id);
            if (product == null)
            {
                return NotFound("The product record couldn't be found.");
            }
            var deletedProduct = iproductRepository.DeleteProduct(deleteProductDTO.Id);
            return Ok(deletedProduct);
        }
    }
}

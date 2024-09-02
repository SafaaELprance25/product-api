using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly List<Product> _products = new List<Product>(); // In-memory storage for demonstration

        // GET: api/products
        [HttpGet]
        public IActionResult GetProducts(int page = 1, int pageSize = 10, string sortBy = "price")
        {
            // Implement pagination and sorting logic here
            var sortedProducts = _products.OrderBy(p => sortBy == "price" ? p.Price : p.EnglishName);
            var paginatedProducts = sortedProducts.Skip((page - 1) * pageSize).Take(pageSize);

            return Ok(paginatedProducts);
        }

        // POST: api/products
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            // Validate and add the product to the storage
            // You'd typically save it to a database here
            _products.Add(product);

            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }

}

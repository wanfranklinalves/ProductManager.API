using Microsoft.AspNetCore.Mvc;
using ProductManager.Core.Models;
using ProductManager.Domain.Interfaces;

namespace ProductManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<Product>> ObterProdutoPorIdAsync(int id)
        {
            string logFile = Path.Combine(Directory.GetCurrentDirectory(), "arquivo.log");
            string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                writer.WriteLine(timeStamp + "[OK] Produto: " + id);
            }

            //_logger.LogInformation("Obtendo o produto com ID");
            var product = await _productService.ObterProdutoPorIdAsync(id);

            if (product == null)
            {
                return BadRequest();
            }

            return Ok(product);
        }
    }
}
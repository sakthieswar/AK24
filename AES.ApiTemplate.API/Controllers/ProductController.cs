using AES.ApiTemplate.BL.Interfaces;
using AES.ApiTemplate.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace AES.ApiTemplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBuisnessLayer _productBL;

        public ProductController(IProductBuisnessLayer productBL)
        {
            this._productBL = productBL;
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IReadOnlyList<Product>> GetProducts()
        {
            return await _productBL.GetProducts();
        }
        [HttpGet]
        [Route("GetProduct")]
        public async Task<Product> GetProduct(int id)
        {
            return await _productBL.GetProduct(id);
        }
        [HttpPost]
        [Route("AddProduuct")]
        public async Task AddProduuct(Product product)
        {
            await _productBL.AddProduuct(product);
        }
    }
}

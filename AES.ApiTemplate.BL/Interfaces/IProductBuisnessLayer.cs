using AES.ApiTemplate.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.BL.Interfaces
{
    public interface IProductBuisnessLayer
    {
        Task<IReadOnlyList<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task AddProduuct(Product product);
    }
}

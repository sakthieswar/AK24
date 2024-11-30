using AES.ApiTemplate.BL.Interfaces;
using AES.ApiTemplate.Models.Models;
using AES.ApiTemplate.Services.Interfaces;
using AES.ApiTemplate.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.BL.BuisnessLogic
{
    public class ProductBuisnessLayer : IProductBuisnessLayer
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerManager _logger;

        public ProductBuisnessLayer(IUnitOfWork unitOfWork, ILoggerManager logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task AddProduuct(Product product)
        {
            try
            {
                var res = await _unitOfWork.Repository<Product>().Add(product);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in while adding product {ex.Message}");
            }
        }

        public async Task<Product> GetProduct(int id)
        {
            try
            {
                Product ss = await _unitOfWork.Repository<Product>().GetById(id);
                return ss;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetProduct {ex.Message}");
                throw ex;
            }
        }

        public async Task<IReadOnlyList<Product>> GetProducts()
        {
            try
            {
                IReadOnlyList<Product> ss = await _unitOfWork.Repository<Product>().GetAll();
                return ss;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetProducts {ex.Message}");
                throw ex;
            }
        }
    }
}

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
    public class UserBuisnessLayer : IUserBuisnessLayer
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerManager _logger;

        public UserBuisnessLayer(IUnitOfWork unitOfWork, ILoggerManager logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public async Task AddUser(User user)
        {
            try
            {
                var res = await _unitOfWork.Repository<User>().Add(user);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in while adding product {ex.Message}");
            }
        }

        public async Task<IReadOnlyList<User>> GetUsers()
        {
            try
            {
                string storedprocedure = "sp_getUsers";
                IReadOnlyList<User> ss = await _unitOfWork.Repository<User>().GetAll(storedprocedure);
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

using AES.ApiTemplate.Models.Models;
using AES.ApiTemplate.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AES.ApiTemplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Route("GetUsers")]
        public async Task<IReadOnlyList<User>> GetUsers()
        {
            string storedprocedure = "sp_getUsers";
            IReadOnlyList<User> ss = await _unitOfWork.Repository<User>().GetAll(storedprocedure);
            return ss;
        }
        
        [HttpPost]
        [Route("AddUser")]
        public async Task AddUser(User product)
        {
            //User prd = new User() { name = "UOW Product", description = "UOW Product" };
            var res = await _unitOfWork.Repository<User>().Add(product);
        }
    }
}

using AES.ApiTemplate.BL.Interfaces;
using AES.ApiTemplate.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace AES.ApiTemplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBuisnessLayer _userBL;

        public UserController(IUserBuisnessLayer userBL)
        {
            this._userBL = userBL;
        }
        [HttpGet]
        [Route("GetUsers")]
        public async Task<IReadOnlyList<User>> GetUsers()
        {
            return await _userBL.GetUsers();
        }
        
        [HttpPost]
        [Route("AddUser")]
        public async Task AddUser(User user)
        {
           await _userBL.AddUser(user);
        }
    }
}

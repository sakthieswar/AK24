using AES.ApiTemplate.Models.Models;

namespace AES.ApiTemplate.BL.Interfaces
{
    public interface IUserBuisnessLayer
    {
        Task AddUser(User user);
        Task<IReadOnlyList<User>> GetUsers();
    }
}

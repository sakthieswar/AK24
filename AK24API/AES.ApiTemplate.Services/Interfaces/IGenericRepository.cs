using AES.ApiTemplate.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.Services.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<IReadOnlyList<T>> GetAll(string storedprocedure);
        Task<T> GetById(int id);
        Task<T> Add(T product);
        Task Update(int id, T product);
        Task Delete(T product);
    }
}

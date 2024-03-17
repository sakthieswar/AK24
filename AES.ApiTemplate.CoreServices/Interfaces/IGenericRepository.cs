using AES.ApiTemplate.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.CoreServices.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        //Task<IEnumerable<TEntity>> GetAllAsync();
        //Task<TEntity> GetByIdAsync(int id);
        //Task InsertAsync(TEntity entity);
        //Task UpdateAsync(TEntity entityToUpdate);
        //Task DeleteAsync(int id);
    }
}

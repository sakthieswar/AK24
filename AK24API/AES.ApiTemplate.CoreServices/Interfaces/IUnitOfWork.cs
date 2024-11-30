using AES.ApiTemplate.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.CoreServices.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Rollback();
        IGenericRepository<T> Repository<T>() where T : BaseEntity;
    }
}

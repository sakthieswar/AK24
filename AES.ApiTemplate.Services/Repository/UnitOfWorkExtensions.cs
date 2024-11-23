using AES.ApiTemplate.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.Services.Repository
{
    public static class UnitOfWorkExtensions
    {
        public static void InsertUpdateDelet<T> (this UnitOfWork unitOfWork, T entity) where T : class, BaseEntity
        {
            if (unitOfWork == null) throw new ArgumentNullException("");
            var repository = unitOfWork.Repository<T>();
            repository.Add(entity);
        }
    }
}

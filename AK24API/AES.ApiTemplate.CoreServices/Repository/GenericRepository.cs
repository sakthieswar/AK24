using AES.ApiTemplate.CoreServices.Interfaces;
using AES.ApiTemplate.Models.Models;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.CoreServices.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IDbConnection _dbConnection;
        private readonly IDbTransaction _dbTransaction;


        public GenericRepository(IDbTransaction dbTransaction)
        {
            _dbConnection = dbTransaction.Connection ?? default!;
            _dbTransaction = dbTransaction;
            SqlMapperExtensions.TableNameMapper = (type) => type.Name;
        }

        //public async Task<IEnumerable<TEntity>> GetAllAsync()
        //{
        //    return await _dbConnection.GetAllAsync<TEntity>(_dbTransaction);
        //}

        //public async Task<TEntity> GetByIdAsync(int id)
        //{
        //    return await _dbConnection.GetAsync<TEntity>(id, _dbTransaction);
        //}

        //public async Task InsertAsync(TEntity entity)
        //{
        //    try
        //    {
        //        entity.CreatedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
        //        await _dbConnection.InsertAsync(entity, _dbTransaction);
        //        _dbTransaction.Commit();
        //    }
        //    catch(Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public async Task UpdateAsync(TEntity entityToUpdate)
        //{
        //    entityToUpdate.ModifiedDate = DateTime.UtcNow;
        //    await _dbConnection.UpdateAsync<TEntity>(entityToUpdate, _dbTransaction);
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var entity = await GetByIdAsync(id);
        //    await _dbConnection.DeleteAsync(entity, _dbTransaction);
        //}
    }
}

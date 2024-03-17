using AES.ApiTemplate.Models.Models;
using AES.ApiTemplate.Services.Context;
using AES.ApiTemplate.Services.Interfaces;
using AES.ApiTemplate.Services.Services;
using System.Collections;
using System.Data;

namespace AES.ApiTemplate.Services.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbStoreContext _context;
        private readonly IDapperr _dapper;
        private Hashtable _repositories;
        private readonly IDbConnection _dbConnection;
        public UnitOfWork(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
            _dbConnection.Open();
        }
        public UnitOfWork(DbStoreContext context, IDapperr dapper)
        {
            _context = context;
            _dapper = dapper;            
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            if (_repositories == null) _repositories = new Hashtable();

            var type = typeof(TEntity).Name;
            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);

                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context, _dapper);
                _repositories.Add(type, repositoryInstance);
            }
            return (IGenericRepository<TEntity>)_repositories[type];
        }
    }
}

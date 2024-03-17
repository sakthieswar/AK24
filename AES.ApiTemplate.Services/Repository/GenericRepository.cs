using AES.ApiTemplate.Services.Context;
using AES.ApiTemplate.Services.Interfaces;
using AES.ApiTemplate.Services.Services;
using System.Data;
using static Dapper.SqlMapper;
using System.Data.Common;
using Microsoft.Extensions.Configuration;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using AES.ApiTemplate.Models.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AES.ApiTemplate.Services.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly IDapperr _dapper;
        private readonly DbStoreContext _context;
        private readonly IConfiguration _config;
        private string Connectionstring = "SqlConnection";
        public GenericRepository(IConfiguration config)
        {
            _config = config;
            SqlMapperExtensions.TableNameMapper = (type) => type.Name;
        }

        public GenericRepository(DbStoreContext context, IDapperr dapper)
        {
            _context = context;
            this._dapper = dapper;
        }

        public Task Add(T product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T product)
        {
            throw new NotImplementedException();
        }
        public async Task<IReadOnlyList<T>> GetAll()
        {
            var type = typeof(T).Name;
            string spname = "sp_get" + type + "s";
            string query = $"SELECT * FROM {type.ToLower()}";
            //using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            //var rr = db.GetAll<List<Product>>().ToList();


            var result = await Task.FromResult(_dapper.GetAll<T>(query, null, CommandType.Text));
            return result;
        }

        public async Task<T> GetById(int id)
        {
            var type = typeof(T).Name;
            string query = $"SELECT * FROM {type.ToLower()} where id = {id}";
            var result = await Task.FromResult(_dapper.Get<T>(query, null, CommandType.Text));
            return result;
        }

        public Task Update(int id, T product)
        {
            throw new NotImplementedException();
        }
    }
}

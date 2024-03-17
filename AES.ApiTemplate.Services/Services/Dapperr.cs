using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;
using AES.ApiTemplate.Services.Context;
using AES.ApiTemplate.Models.Models;
using AES.ApiTemplate.Services.Interfaces;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using NLog.Fluent;

namespace AES.ApiTemplate.Services.Services
{
    public class Dapperr : IDapperr
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "SqlConnection";
        public Dapperr(IConfiguration config)
        {
            _config = config;
        }
        public void Dispose()
        {
        }


        public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            //db.Open();
            //T obj;
            //obj = (T)db.Get<T>(1);

            //T t = object(T);
            //t = db.Get<T>(1);
            //var res = db.Get<T>(1);
            return db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }

        public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                var type = typeof(T).Name;
                //var res = db.GetAll<List<Product>>().AsQueryable();
               //var res = db.GetAll<List<T>>().AsQueryable();
                var res1 = db.Query<T>(sp, parms, commandType: commandType).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }

        public List<T> GetAllByModelName<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            var type = typeof(T).Name;
            var res = db.GetAll<List<T>>().ToList();
            var res1 = db.Query<T>(sp, parms, commandType: commandType).ToList();
            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }
        public void GetAllMultiple(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new NotImplementedException();
        }

        public DbConnection GetDbconnection()
        {
            return new SqlConnection(_config.GetConnectionString(Connectionstring));
        }

        public T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }

        public T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }

        //public List<TEntity> GetAllAsync<TEntity>()
        //{
        //    using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
        //    return _dbConnection.GetAll<TEntity>(_dbTransaction);
        //}
    }
}

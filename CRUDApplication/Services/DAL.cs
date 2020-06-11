using CRUDApplication.Interface;
using CRUDApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Services
{
    public abstract class DAL<T> : IDAL<T> where T : class
    {
        protected readonly DbsContext _context;
        public DAL(DbsContext  context)
        {
            _context = context;
        }

        [Obsolete]
        public async Task<List<T>> ExcuteProcedureAsync(string sqlQuery, params object[] parameter)
        {
            List<T> lst = new List<T>();
            try
            {
                if (parameter != null)
                    lst = await _context.Query<T>().FromSql(sqlQuery, parameter).ToListAsync();
                else
                    lst = await _context.Query<T>().FromSql(sqlQuery).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }
        [Obsolete]
        public List<T> ExcuteProcedure(string sqlQuery, params object[] parameter)
        {
            List<T> lst = new List<T>();
            try
            {
                if (parameter != null)
                    lst = _context.Query<T>().FromSql(sqlQuery, parameter).ToList();
                else
                    lst = _context.Query<T>().FromSql(sqlQuery).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }

        [Obsolete]
        public void ExcuteNonQuery(string sqlQuery, params object[] parameter)
        {
            if (parameter != null)
                _context.Database.ExecuteSqlCommand(sqlQuery, parameter);
            else
                _context.Database.ExecuteSqlCommand(sqlQuery);
        }

        [Obsolete]
        public async Task ExcuteNonQueryAsync(string sqlQuery, params object[] parameter)
        {
            if (parameter != null)
                await _context.Database.ExecuteSqlCommandAsync(sqlQuery, parameter);
            else
                await _context.Database.ExecuteSqlCommandAsync(sqlQuery);
        } 

    }
}

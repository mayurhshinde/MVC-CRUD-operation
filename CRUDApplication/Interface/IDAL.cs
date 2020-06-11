using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Interface
{
    public interface IDAL<T> where T : class
    {
        Task<List<T>> ExcuteProcedureAsync(string sqlQuery, params object[] parameter);

        List<T> ExcuteProcedure(string sqlQuery, params object[] parameter);

        void ExcuteNonQuery(string sqlQuery, params object[] parameter);

        Task ExcuteNonQueryAsync(string sqlQuery, params object[] parameter);
    }
}

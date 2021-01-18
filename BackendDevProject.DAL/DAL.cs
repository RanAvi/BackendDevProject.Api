using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendDevProject.DAL
{
    public static class DAL<T>
    {


        public static async Task<bool> Create(DynamicParameters parameters, string sql)
        {
            using var con = Helper.CreateConnection();
            var rowAffected = await con.ExecuteAsync(sql, parameters);
            return (rowAffected > 0) ? true : false;

        }

        public static async Task<bool> Delete(DynamicParameters parameters, string sql)
        {
            using var con = Helper.CreateConnection();
            var rowAffected = await con.ExecuteAsync(sql, parameters);
            return (rowAffected > 0) ? true : false;

        }

        public static async Task<T> Get(DynamicParameters parameters, string sql)
        {
            using var con = Helper.CreateConnection();
            var t = await con.QuerySingleAsync<T>(sql, parameters);
            return t;

        }

        public static async Task<IEnumerable<T>> GetAll(DynamicParameters parameters, string sql)
        {
            using var con = Helper.CreateConnection();
            var t = await con.QueryAsync<T>(sql, parameters);
            return t;

        }

        public static async Task<bool> Update(DynamicParameters parameters, string sql)
        {

            using var con = Helper.CreateConnection();
            var rowAffected = await con.ExecuteAsync(sql, parameters);
            return (rowAffected > 0) ? true : false;

        }



    }
}

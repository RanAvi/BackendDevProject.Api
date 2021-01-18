using BackendDevProject.DAL;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace BackendDevProject.Respository
{
    public class DatabaseSetup : IDatabaseSetup
    {
        private readonly DatabaseConfiguration _config;

        //public static SqliteConnection GetConnection { get; private set; }

        private SqliteConnection GetConnection { get { return new SqliteConnection($"Data Source={_config.DatabaseName}"); } }

        public DatabaseSetup(DatabaseConfiguration config)
        {
            _config = config;
            //GetConnection = new SqliteConnection($"Data Source={_config.DatabaseName}");
        }




        public void Setup()
        {
            string sql = string.Empty;

            using var connection = GetConnection;

            var tables = _config.Tables.ToList();
            var createTable = _config.CreateTable.ToList();

            //check if the table Exist

            foreach (var table in tables)
            {
                var createTablesql = createTable.Where(x => x.Contains(table)).FirstOrDefault();

                var Exist = IsTableExist(table, connection, _config.TABLE);

                if (!Exist)
                {
                    connection.Execute(createTablesql);
                }

            }

        }



        private bool IsTableExist(string tableName, SqliteConnection connection, string sql)
        {

            var sqlreplace = sql.Replace("{tableName}", tableName);

            var table = connection.Query<string>(sqlreplace);
            var tableFirst = table.FirstOrDefault();

            var result = (tableFirst.IsNULLorEmpty() && tableFirst == tableName) ? true : false;

            return result;



        }

    }
}

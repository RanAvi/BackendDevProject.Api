using Microsoft.Data.Sqlite;

namespace BackendDevProject.DAL
{
    public static class Helper
    {

        public static SqliteConnection CreateConnection(string dbName = "DB.sqlite")
        {
            return new SqliteConnection($"Data Source={dbName}");

        }


        public static bool IsNULLorEmpty(this string table, string value = "")
        {
            return string.IsNullOrEmpty(value);
        }




    }
}

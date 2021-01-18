namespace BackendDevProject.Respository
{
    public static class SqlOpertion
    {
        public const string CREATE = "CREATE";
        public const string SELECT = "SELECT";
        public const string INSERT = "INSERT";
        public const string ALTER = "ALTER";
        public const string DELETE = "DELETE";
        public const string UPDATE = "UPDATE";



    }


    public static class ColumnConstraints
    {
        public const string PRIMARYKEY = "PRIMARY KEY";
        public const string UNIQUE = "UNIQUE ";
        public const string NOTNULL = "NOT NULL";
        public const string DEFAULT = "DEFAULT ";
        public const string NULL = "NULL";
        public const string ALTERTABLE = "ALTER TABLE";
        public const string ADDCOLUMN = "ADD COLUMN";
        public const string AUTOINCREMENT = "AUTOINCREMENT ";


    }


    public static class Datatypes
    {
        public const string INTEGER = "INTEGER";
        public const string REAL = "REAL";
        public const string TEXT = "TEXT ";
        public const string BLOB = "BLOB";
        public const string NUMERIC = "NUMERIC";



    }






    //public static string SelectOpertionToDo(string opertionName, Dictionary<string, string> columnAndType, string table_name)
    //{

    //    var dataTable = new DataTable(table_name);

    //    dataTable.Columns.Add("", typeof(string));

    //    string columns = string.Join(","
    //                  , dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName));

    //    //string values = string.Join(","
    //    //          , dataTable.Columns.Cast<DataColumn>().Select(c => string.Format("@{0}", c.ColumnName)));

    //    //var sql=$"CREATE TABLE {table_name}( column1 datatype, column2 datatype, column3 datatype)";

    //    ////--Insert into columns in order:
    //    //sql=$"INSERT INTO table_name  VALUES(value1, value2)";

    //    ////--Insert into columns by name:
    //    //sql = $"INSERT INTO {table_name} (column1, column2) VALUES (value1, value2);";

    //    //sql= $"ALTER TABLE table_name ADD column_name datatype";



    //}


}

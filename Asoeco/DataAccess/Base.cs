using Microsoft.Data.Sqlite;

namespace Asoeco.DataAccess
{
    public class Base
    {
        public static string GetConnectionString()
        {
            string pathDataBase = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"", "Data\\AsoecoDB.db");
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = pathDataBase };
            var connectionString = connectionStringBuilder.ToString();
            return connectionString;
        }

    }
}

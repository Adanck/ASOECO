using Microsoft.Data.Sqlite;

namespace Asoeco.DataAccess
{
    public class Base
    {
        SqliteConnection conn = new SqliteConnection("Data Source=.\AsoecoDb.db;Version=3;");

    }
}

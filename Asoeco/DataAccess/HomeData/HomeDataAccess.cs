using Asoeco.Models;
using Microsoft.Data.Sqlite;

namespace Asoeco.DataAccess.HomeData
{
    public class HomeDataAccess :Base, IHomeDataAccess
    {
        public HomeModel getHome()
        {
            try
            {
                var response = new HomeModel();
                using (SqliteConnection sql_con = new SqliteConnection(GetConnectionString()))
                {
                    using (SqliteCommand sql_cmd = new SqliteCommand())
                    {
                        sql_cmd.CommandText = "select * from Configuration";
                        sql_cmd.Connection = sql_con;
                        sql_cmd.Connection.Open();
                        sql_cmd.Prepare();


                        SqliteDataReader reader = sql_cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            response.History = (string)reader["History"];
                            response.Mision = (string)reader["Mision"];
                            response.Vision = (string)reader["Vision"];
                            //response.About = (string)reader["About"];
                        }
                    }
                }
                return response;
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }
        public AssociatesModel getAssociates()
        {
            try
            {
                var response = new AssociatesModel();
                
                return response;
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }
    }
}

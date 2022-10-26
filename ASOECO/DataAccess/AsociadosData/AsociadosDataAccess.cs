using Asoeco.DataAccess.AsociadosData;
using Asoeco.Models;
using Microsoft.Data.Sqlite;

namespace Asoeco.DataAccess.AsociadosData
{
    public class AsociadosDataAccess : Base, IAsociadosDataAccess
    {
        public AssociatesModel getAssociates()
        {
            try
            {
                var response = new AssociatesModel();
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
                            //response.History = (string)reader["History"];
                            //response.Mision = (string)reader["Mision"];
                            //response.Vision = (string)reader["Vision"];
                            //response.Asociados = (string)reader["Asociados"];
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
    }
}
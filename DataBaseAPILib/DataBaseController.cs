using DataBaseAPILib.Enums;
using System;
using System.Data.SqlClient;

namespace DataBaseAPILib
{
    public class DataBaseController<T> where T : class
    {
        SqlConnection sqlConnection;
        string connectionstring;

        public ConnectionState Connect() 
        {
            try
            {
                return ConnectionState.Connected;
            }
            catch (Exception er) 
            {
                return ConnectionState.Failed;
            }
        }
        public string Get(string command) 
        {
            using (SqlCommand sqlcommand = new SqlCommand())
            {
                sqlcommand.CommandText = command;
                sqlcommand.Connection = sqlConnection;
                SqlDataReader reader = sqlcommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0) + " " + reader.GetString(1);
                    }
                    return "1";
                }
                else 
                { 
                    return null; 
                }

            }
        }
    }
}

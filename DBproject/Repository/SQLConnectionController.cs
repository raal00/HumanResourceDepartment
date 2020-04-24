using System;
using System.Data.SqlClient;

namespace DBproject.Repository
{
    public static class SQLConnectionController
    {
        private static string connectionStringNew = "Data Source=SQL5059.site4now.net;Initial Catalog=DB_A5D903_humanDeptDB;User Id=DB_A5D903_humanDeptDB_admin;Password=1357997531Sg;";
        private static string connectionString = @"Data Source =.\SQLEXPRESS;Initial Catalog = HumanResourcesDepartmentDB; Integrated Security = True";
        public static SqlConnection sqlConnection;
        public static ConnectionStateEnum ConnectionState;

        public static void ConnectToServer(this SqlConnection connection)
        {
            sqlConnection = new SqlConnection(connectionStringNew);
            try 
            {
                sqlConnection.Open();
                sqlConnection.StateChange += Connection_StateChange;
                ConnectionState = ConnectionStateEnum.CONNECTED;
            }
            catch (Exception er) 
            {
                ConnectionState = ConnectionStateEnum.FAIL;
                Console.WriteLine(er.Message);
            }
        }

        private static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            switch (e.CurrentState) 
            {
                case System.Data.ConnectionState.Open:
                    ConnectionState = ConnectionStateEnum.CONNECTED;
                    break;
                case System.Data.ConnectionState.Closed:
                    ConnectionState = ConnectionStateEnum.DISCONNECTED;
                    break;
                case System.Data.ConnectionState.Broken:
                    ConnectionState = ConnectionStateEnum.BROKEN;
                    break;
                default:
                    break;
            }
        }
    }
}

using DBproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DBproject.Repository.ModelRepositories
{
    public class FailureToAppearRepository : IRepository<FailureToAppear>
    {
        SqlConnection connection;
        SqlCommand command;

        public FailureToAppearRepository()
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }

        public int Create(FailureToAppear item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE DB_A5D903_humanDeptDB " +
                                  "INSERT INTO dbo.failureToAppear (Date, reason, EmployeeID)" +
                                  $"VALUES ('{item.Date.ToShortDateString()}','{item.Reason}',{item.EmployeeID})";
            command.ExecuteNonQuery();
            return 0;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public FailureToAppear GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FailureToAppear> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(FailureToAppear item)
        {
            throw new NotImplementedException();
        }
    }
}

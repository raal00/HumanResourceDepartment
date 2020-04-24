using DBproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DBproject.Repository.ModelRepositories
{
    public class DismissalOrderRepository : IRepository<DismissalOrder>
    {
        SqlConnection connection;
        SqlCommand command;

        public DismissalOrderRepository()
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }

        public int Create(DismissalOrder item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE DB_A5D903_humanDeptDB " +
                                  "INSERT INTO dbo.dismissalOrder (EndDate, reason, EmployeeID)" +
                                  $"VALUES ('{item.EndDate.ToShortDateString()}','{item.Reason}',{item.EmployeeID})";
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

        public DismissalOrder GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DismissalOrder> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(DismissalOrder item)
        {
            throw new NotImplementedException();
        }
    }
}

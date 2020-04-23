using DBproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DBproject.Repository.ModelRepositories
{
    public class SickLeaveOrderRepository : IRepository<SickLeaveOrder>
    {
        SqlConnection connection;
        SqlCommand command;

        public SickLeaveOrderRepository()
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }
        public int Create(SickLeaveOrder item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE HumanResourcesDepartmentDB " +
                                  "INSERT INTO dbo.SickLeaveOrder (StartDate, EndDate, EmployeeID)" +
                                  $"VALUES ('{item.StartDate.ToShortDateString()}','{item.EndDate.ToShortDateString()}',{item.EmployeeID})";
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

        public SickLeaveOrder GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SickLeaveOrder> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(SickLeaveOrder item)
        {
            throw new NotImplementedException();
        }
    }
}

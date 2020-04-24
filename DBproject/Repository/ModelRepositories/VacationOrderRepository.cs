using DBproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DBproject.Repository.ModelRepositories
{
    public class VacationOrderRepository : IRepository<VacationOrder>
    {

        SqlConnection connection;
        SqlCommand command;

        public VacationOrderRepository()
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }
        public int Create(VacationOrder item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE DB_A5D903_humanDeptDB " +
                                  "INSERT INTO dbo.vacationOrder (StartDate, EndDate, PaymentDays, EmployeeID)" +
                                  $"VALUES ('{item.StartDate.ToShortDateString()}','{item.EndDate.ToShortDateString()}',{item.PaymentDays},{item.EmployeeID})";
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

        public VacationOrder GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VacationOrder> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(VacationOrder item)
        {
            throw new NotImplementedException();
        }
    }
}

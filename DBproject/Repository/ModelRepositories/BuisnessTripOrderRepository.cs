using DBproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DBproject.Repository.ModelRepositories
{
    public class BuisnessTripOrderRepository : IRepository<BuisnessTripOrder>
    {
        SqlConnection connection;
        SqlCommand command;

        public BuisnessTripOrderRepository()
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }

        public int Create(BuisnessTripOrder item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE HumanResourcesDepartmentDB " +
                                  "INSERT INTO dbo.businessTripOrder (Position, StartDate, EndDate, Payment, EmployeeID)" +
                                  $"VALUES ('{item.Position}','{item.StartDate.ToShortDateString()}','{item.EndDate.ToShortDateString()}'," +
                                  $"'{item.Payment}',{item.EmployeeID})";
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

        public BuisnessTripOrder GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BuisnessTripOrder> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(BuisnessTripOrder item)
        {
            throw new NotImplementedException();
        }
    }
}

using DBproject.Models;
using System;
using System.Data.SqlClient;

namespace DBproject.Repository.ModelRepositories
{
    public class Employee_PositionRepository : IRepository<Employee_Position>
    {
        SqlConnection connection;
        SqlCommand command;

        public Employee_PositionRepository()
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }

        public int Create(Employee_Position item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE HumanResourcesDepartmentDB " + 
                                  "INSERT INTO dbo.emplyee_position(idPosition,salary,idEmployee) " +
                                 $"VALUES ({item.IdPosition},{item.Salary},{item.IdEmployee})";
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

        public Employee_Position GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<Employee_Position> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(Employee_Position item)
        {
            throw new NotImplementedException();
        }
    }
}

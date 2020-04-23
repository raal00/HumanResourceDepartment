using DBproject.Models;
using System;
using System.Data.SqlClient;

namespace DBproject.Repository.ModelRepositories
{
    public class EmployeeRepository : IRepository<employee>
    {
        SqlConnection connection;
        SqlCommand command;

        public EmployeeRepository() 
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }

        public int Create(employee item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE HumanResourcesDepartmentDB " + 
                                  "INSERT INTO dbo.Employee(name,secondname,thirdname,birthday,passport) " +
                                  $"VALUES ('{item.Name}','{item.SecondName}','{item.ThirdName}','{item.BirthDay}','{item.Passport}')";
            command.ExecuteNonQuery();
            command.CommandText = "SELECT SCOPE_IDENTITY()";
            decimal lastId = (decimal)command.ExecuteScalar();
            return (int)lastId;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public employee GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<employee> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(employee item)
        {
            throw new NotImplementedException();
        }
    }
}

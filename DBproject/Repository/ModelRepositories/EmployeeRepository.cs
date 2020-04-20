using DBproject.Models;
using System;
using System.Data.SqlClient;

namespace DBproject.Repository
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

        public void Create(employee item)
        {
            command.CommandText = "";
            
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

        public void Update(employee item)
        {
            throw new NotImplementedException();
        }
    }
}

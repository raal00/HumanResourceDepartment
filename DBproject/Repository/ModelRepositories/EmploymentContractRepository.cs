using DBproject.Models;
using System;
using System.Data.SqlClient;

namespace DBproject.Repository.ModelRepositories
{
    public class EmploymentContractRepository : IRepository<EmploymentContract>
    {
        SqlConnection connection;
        SqlCommand command;

        public EmploymentContractRepository() 
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }

        public int Create(EmploymentContract item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public EmploymentContract GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<EmploymentContract> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(EmploymentContract item)
        {
            throw new NotImplementedException();
        }
    }
}

using DBproject.Models;
using System;
using System.Data.SqlClient;
namespace DBproject.Repository.ModelRepositories
{
    public class PositionRepository : IRepository<Position>
    {
        SqlConnection connection;
        SqlCommand command;

        public PositionRepository()
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }

        public int Create(Position item)
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

        public Position GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<Position> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(Position item)
        {
            throw new NotImplementedException();
        }
    }
}

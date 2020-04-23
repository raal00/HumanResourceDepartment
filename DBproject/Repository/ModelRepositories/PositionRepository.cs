using DBproject.Models;
using System;
using System.Collections.Generic;
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
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE HumanResourcesDepartmentDB " + 
                                  "INSERT INTO dbo.position(StartDate,EndDate,PositionLabel) " +
                                 $"VALUES ('{item.StartDate.ToShortDateString()}',NULL,'{item.PositionLabel}')";
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

        public Position GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Position> GetList()
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

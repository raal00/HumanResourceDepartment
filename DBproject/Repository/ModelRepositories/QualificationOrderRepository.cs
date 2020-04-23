using DBproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DBproject.Repository.ModelRepositories
{
    public class QualificationOrderRepository : IRepository<QualificationOrder>
    {

        SqlConnection connection;
        SqlCommand command;

        public QualificationOrderRepository()
        {
            connection = SQLConnectionController.sqlConnection;
            command = new SqlCommand();
            command.Connection = connection;
        }
        public int Create(QualificationOrder item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE HumanResourcesDepartmentDB " +
                                  "INSERT INTO dbo.qualificationOrder (reason, StartDate, EndDate, EmployeeID)" +
                                  $"VALUES ('{item.Reason}','{item.StartDate.ToShortDateString()}','{item.EndDate.ToShortDateString()}',{item.EmployeeID})";
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

        public QualificationOrder GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QualificationOrder> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(QualificationOrder item)
        {
            throw new NotImplementedException();
        }
    }
}

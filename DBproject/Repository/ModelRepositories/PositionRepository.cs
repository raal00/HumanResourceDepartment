﻿using DBproject.Models;
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
            command.CommandText = "USE DB_A5D903_humanDeptDB " + 
                                  "INSERT INTO dbo.position(StartDate,EndDate,PositionLabel) " +
                                 $"VALUES ('{item.StartDate.ToShortDateString()}',NULL,N'{item.PositionLabel}')";
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
            return 0;
        }

        public void UpdateDate() 
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return;
            int Employeeid = 0;
            DateTime? date = DateTime.Now;
            date.Value.AddDays(14);
            command.CommandText = "USE DB_A5D903_humanDeptDB " +
                                  $"UPDATE dbo.position SET EndDate = '{date}' " +
                                  $"WHERE EmployeeID = {Employeeid}";
            command.ExecuteNonQuery();
        }
    }
}

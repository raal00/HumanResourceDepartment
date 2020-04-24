using DBproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DBproject.Models.SpecModels.RequestModels;
using DBproject.Models.SpecModels.ResponseModels;

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

        public StaffModelRequest GetStaffModel() 
        {
            StaffModelRequest model = new StaffModelRequest();
            return model;
        }
        public StaffListResponse GetStaffList() 
        {
            StaffListResponse model = new StaffListResponse();
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                throw new ArgumentNullException();
            command.CommandText = "USE DB_A5D903_humanDeptDB " +
                                  "SELECT [id], [secondname] FROM dbo.Employee";
            model.StaffList = new List<StaffModelRequest>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                model.StaffList.Add(new StaffModelRequest()
                {
                     Id = (int)reader.GetValue(0),
                     Name = (string)reader.GetValue(1)
                }) ;
            }
            reader.Close();
            return model;
        }


        public int Create(employee item)
        {
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            command.CommandText = "USE DB_A5D903_humanDeptDB " + 
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

        public IEnumerable<employee> GetList()
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

using DBproject.Models;
using System;
using System.Collections.Generic;
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
            if (connection == null || SQLConnectionController.ConnectionState != ConnectionStateEnum.CONNECTED)
                return -1;
            string isVacPay = item.IsVacationPay == true? "'TRUE'" : "'FALSE'";
            string isTravPay = item.IsTravelingPay == true ? "'TRUE'" : "'FALSE'";
            string isSickPay = item.IsSickLeavePay == true ? "'TRUE'" : "'FALSE'";
            command.CommandText = "USE DB_A5D903_humanDeptDB " +
                                  "INSERT INTO dbo.employmentСontract (position,salary,conditions,vacations,isVacationPay,isTravelingPay,isSickLeavePay,EmployeeID) " +
                                 $"VALUES ('{item.Position}',{item.Salary},'{item.Conditions}',{item.Vacations},{isVacPay},{isTravPay},{isSickPay},{item.EmployeeID})";
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

        public EmploymentContract GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmploymentContract> GetList()
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

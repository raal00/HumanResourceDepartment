using System;
using System.ComponentModel.DataAnnotations;

namespace DBproject.Models
{
    public class EmploymentContract
    {
        [MaxLength(20)]
        public string Position;

        [Range(0, 99999)]
        public int Salary;
        [MaxLength(200)]
        public string Conditions;
        [Range(0, 999)]
        public int Vacations;
        
        public bool IsVacationPay;
        public bool IsTravelingPay;
        public bool IsSickLeavePay;
        public int EmployeeID;
    }
}

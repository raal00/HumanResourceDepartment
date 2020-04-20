using System;
using System.ComponentModel.DataAnnotations;

namespace DBproject.Models
{
    public class SickLeaveOrder
    {
        [DataType(DataType.Date)]
        public DateTime StartDate;
        [DataType(DataType.Date)]
        public DateTime EndDate;
        public int EmployeeID;
    }
}

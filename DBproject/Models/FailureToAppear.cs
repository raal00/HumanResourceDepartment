using System;
using System.ComponentModel.DataAnnotations;

namespace DBproject.Models
{
    public class FailureToAppear
    {
        [DataType(DataType.Date)]
        public DateTime Date;
        [MaxLength(20)]
        public string Reason;
        public int EmployeeID;
    }
}

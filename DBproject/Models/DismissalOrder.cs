using System;
using System.ComponentModel.DataAnnotations;

namespace DBproject.Models
{
    public class DismissalOrder
    {
        [DataType(DataType.Date)]
        public DateTime EndDate;

        [MaxLength(20)]
        public string Reason;
        public int EmployeeID;
    }
}

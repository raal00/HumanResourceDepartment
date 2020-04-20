using System;
using System.ComponentModel.DataAnnotations;

namespace DBproject.Models
{
    public class VacationOrder
    {
        [DataType(DataType.Date)]
        public DateTime StartDate;
        [DataType(DataType.Date)]
        public DateTime EndDate;

        [Range(0, 99999)]
        public int PaymentDays;
        public int EmployeeID;
    }
}

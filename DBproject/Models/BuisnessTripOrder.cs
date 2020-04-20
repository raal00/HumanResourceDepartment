using System;
using System.ComponentModel.DataAnnotations;

namespace DBproject.Models
{
    public class BuisnessTripOrder
    {
        [MaxLength(20)]
        public string Position;

        [DataType(DataType.Date)]
        public DateTime StartDate;
        [DataType(DataType.Date)]
        public DateTime EndDate;

        [MaxLength(20)]
        public string Payment;
        public int EmployeeID;
    }
}

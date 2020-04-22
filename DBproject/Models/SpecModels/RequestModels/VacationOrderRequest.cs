using System;

namespace DBproject.Models.SpecModels.RequestModels
{
    public class VacationOrderRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PaymentDays { get; set; }
        public int EmployeeID { get; set; }
    }
}

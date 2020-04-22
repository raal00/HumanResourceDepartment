using System;

namespace DBproject.Models.SpecModels.RequestModels
{
    public class SickOrderRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeID { get; set; }
    }
}

using System;

namespace DBproject.Models.SpecModels.RequestModels
{
    public class QualificationOrderRequest
    {
        public string Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeID { get; set; }
    }
}

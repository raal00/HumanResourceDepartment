using System;

namespace DBproject.Models.SpecModels.RequestModels
{
    public class FailureToAppearRequest
    {
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public int EmployeeID { get; set; }
    }
}

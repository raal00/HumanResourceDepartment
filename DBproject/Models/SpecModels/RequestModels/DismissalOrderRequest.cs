using System;

namespace DBproject.Models.SpecModels.RequestModels
{
    public class DismissalOrderRequest
    {
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public int EmployeeID { get; set; }
    }
}

using System;

namespace DBproject.Models.SpecModels.RequestModels
{
    public class BuisnessTripOrderRequest
    {
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Payment { get; set; }
        public int EmployeeID { get; set; }
    }
}

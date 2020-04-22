using System;

namespace DBproject.Models.SpecModels
{
    public class PersonRequest
    {
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string TName { get; set; }
        public DateTime? Birthday { get; set; }
        public string PassportId { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Conditions { get; set; }
        public int VacationDays { get; set; }
        public bool IsVacationPay { get; set; }
        public bool IsTravelingPay { get; set; }
        public bool IsSickPay { get; set; }
    }
}

using System;

namespace DBproject.Models
{
    public class Position
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PositionLabel { get; set; }
    }
}

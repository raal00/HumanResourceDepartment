using System;
using System.ComponentModel.DataAnnotations;

namespace DBproject.Models
{
    public class Employee_Position
    {
        public int IdEmployee;
        public int IdPosition;
        
        [Range(0, 99999)]
        public int Salary;
    }
}

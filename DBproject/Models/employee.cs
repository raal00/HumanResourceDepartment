using System;
using System.ComponentModel.DataAnnotations;

namespace DBproject.Models
{
    public class employee
    {
        [MaxLength(20)]
        public string Name;
        [MaxLength(20)]
        public string SecondName;
        [MaxLength(20)]
        public string ThirdName;

        [DataType(DataType.Date)]
        public DateTime? BirthDay;

        [MaxLength(20)]
        public string Passport;
    }
}

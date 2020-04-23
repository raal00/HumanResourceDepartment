using System;
using System.Collections.Generic;
namespace DBproject.Models.SpecModels.RequestModels
{
    public class StaffListResponse
    {
        public List<StaffModelRequest> StaffList { get; set; }
        public string Message { get; set; }
    }
}

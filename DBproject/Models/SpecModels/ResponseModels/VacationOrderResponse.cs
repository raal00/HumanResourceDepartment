using System;

namespace DBproject.Models.SpecModels.ResponseModels
{
    public class VacationOrderResponse
    {
        public RequestState State { get; set; }
        public string Message { get; set; }
    }
}

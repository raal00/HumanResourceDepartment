using System;

namespace DBproject.Models.SpecModels.ResponseModels
{
    public class SickOrderResponse
    {
        public RequestState State { get; set; }
        public string Message { get; set; }
    }
}

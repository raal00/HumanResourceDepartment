using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBproject.Models.SpecModels;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("staff")]
    public class StaffController : Controller
    {
        [Route("hiring")]
        public IActionResult Hiring()
        {
            return View();
        }
        
        [Route("newEmployeeRequest")]
        public JsonResult NewEmployeeRequest(PersonRequest request) 
        {
            PersonResponse response = new PersonResponse();
            response.Message = "";
            response.State = Models.RequestState.COMPLETED;
            return Json(response);
        }
    }
}
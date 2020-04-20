using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("Staff")]
    public class StaffController : Controller
    {
        [Route("Hiring")]
        public IActionResult Hiring()
        {
            return View();
        }
    }
}
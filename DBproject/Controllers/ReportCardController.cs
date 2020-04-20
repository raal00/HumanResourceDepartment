using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("ReportCard")]
    public class ReportCardController : Controller
    {
        [Route("ReportCardPanel")]
        public IActionResult ReportCardPanel()
        {
            return View();
        }
    }
}
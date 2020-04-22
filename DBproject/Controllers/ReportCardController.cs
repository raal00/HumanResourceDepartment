using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("reportCard")]
    public class ReportCardController : Controller
    {
        [Route("reportCardPanel")]
        public IActionResult ReportCardPanel()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("Order")]
    public class OrderController : Controller
    {
        [Route("OrderPanel")]
        public IActionResult OrderPanel()
        {
            return View();
        }
    }
}
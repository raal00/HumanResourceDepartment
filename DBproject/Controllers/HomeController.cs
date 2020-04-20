using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            //DataBaseAPILib.DataBaseController<Сотрудник> dataBaseController = new DataBaseAPILib.DataBaseController<Сотрудник>();
            //dataBaseController.Connect();
            //string pzd = dataBaseController.Get("SELECT * FROM dbo.Сотрудник");
            return View();
        }
    }
}
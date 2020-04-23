using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBproject.Models.SpecModels;
using DBproject.Repository.ModelRepositories;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("staff")]
    public class StaffController : Controller
    {
        private readonly Employee_PositionRepository _Employee_PositionRepository;
        private readonly EmploymentContractRepository _EmploymentContractRepository;
        private readonly EmployeeRepository _EmployeeRepository;
        private readonly PositionRepository _positionRepository;
        
        public StaffController() 
        {
            _Employee_PositionRepository = new Employee_PositionRepository();
            _EmploymentContractRepository = new EmploymentContractRepository();
            _EmployeeRepository = new EmployeeRepository();
            _positionRepository = new PositionRepository();
        }

        [Route("hiring")]
        public IActionResult Hiring()
        {
            return View();
        }
        
        [Route("newEmployeeRequest")]
        public JsonResult NewEmployeeRequest(PersonRequest request) 
        {
            PersonResponse response = new PersonResponse();
            try
            {
                int employeeId = _EmployeeRepository.Create(new Models.employee()
                {
                    BirthDay = request.Birthday,
                    Name = request.Fname,
                    SecondName = request.Sname,
                    ThirdName = request.TName,
                    Passport = request.PassportId
                });
                int positionId = _positionRepository.Create(new Models.Position() { 
                     EndDate = null,
                     PositionLabel = request.Position,
                     StartDate = request.StartWork
                });
                response.Message = "Сотрудник успешно добавлен";
                response.State = Models.RequestState.COMPLETED;
            }
            catch(Exception er) 
            {
                response.Message = er.Message;
                response.State = Models.RequestState.FAILED;
            }
            return Json(response);
        }
    }
}
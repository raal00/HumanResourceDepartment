using System;
using System.Collections.Generic;
using DBproject.Models.SpecModels;
using DBproject.Repository.ModelRepositories;
using DBproject.Models.SpecModels.RequestModels;
using DBproject.Models.SpecModels.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("order")]
    public class OrderController : Controller
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly BuisnessTripOrderRepository _buisnessTripOrderRepository;
        private readonly DismissalOrderRepository _dismissalOrderRepository;
        private readonly FailureToAppearRepository _failureToAppearRepository;
        private readonly QualificationOrderRepository _qualificationOrderRepository;
        private readonly SickLeaveOrderRepository _sickLeaveOrderRepository;
        private readonly VacationOrderRepository _vacationOrderRepository;
        public OrderController() 
        {
            _employeeRepository = new EmployeeRepository();
            _buisnessTripOrderRepository = new BuisnessTripOrderRepository();
            _dismissalOrderRepository = new DismissalOrderRepository();
            _failureToAppearRepository = new FailureToAppearRepository();
            _qualificationOrderRepository = new QualificationOrderRepository();
            _sickLeaveOrderRepository = new SickLeaveOrderRepository();
            _vacationOrderRepository = new VacationOrderRepository();
        }

        [Route("orderPanel")]
        public IActionResult OrderPanel()
        {
            return View();
        }
        [Route("loadStaffList")]
        public JsonResult LoadStaffList() 
        {
            StaffListResponse response = _employeeRepository.GetStaffList();            
            return Json(response);
        }


        [Route("sendSickOrder")]
        public JsonResult SendSickOrder(SickOrderRequest request) 
        {
            SickOrderResponse response = new SickOrderResponse();
            try
            {
                _sickLeaveOrderRepository.Create(new Models.SickLeaveOrder()
                {
                    EmployeeID = request.EmployeeID,
                    EndDate = request.EndDate,
                    StartDate = request.StartDate
                });
                response.State = Models.RequestState.COMPLETED;
                response.Message = "Приказ о больничном добавлен в базу." +
                                   $"\nНомер сотрудника: {request.EmployeeID}";
            }
            catch(Exception er) 
            {
                response.State = Models.RequestState.FAILED;
                response.Message = er.Message;
            }
            return Json(response);
        }

        [Route("sendQualificationOrder")]
        public JsonResult SendQualificationOrder(QualificationOrderRequest request)
        {
            QualificationOrderResponse response = new QualificationOrderResponse();
            try 
            {
                _qualificationOrderRepository.Create(new Models.QualificationOrder() 
                { 
                    EmployeeID = request.EmployeeID,
                    EndDate = request.EndDate, 
                    Reason = request.Reason, 
                    StartDate = request.StartDate
                });
                response.State = Models.RequestState.COMPLETED;
                response.Message = "Приказ об повышении квалификации сотрудника добавлен в базую." +
                                   $"\nНомер сотрудника: {request.EmployeeID}";
            }
            catch (Exception er) 
            {
                response.State = Models.RequestState.FAILED;
                response.Message = er.Message;
            }
            return Json(response);
        }

        [Route("sendVacationOrder")]
        public JsonResult SendVacationOrder(VacationOrderRequest request)
        {
            VacationOrderResponse response = new VacationOrderResponse();
            try 
            {
                _vacationOrderRepository.Create(new Models.VacationOrder() 
                {
                     EmployeeID = request.EmployeeID,
                     EndDate = request.EndDate,
                     PaymentDays = request.PaymentDays,
                     StartDate = request.StartDate
                });
                response.State = Models.RequestState.COMPLETED;
                response.Message = "Приказ об отправке в отпуск добавлен в базу" +
                                   $"Номер сотрудника: {request.EmployeeID}";
            } 
            catch (Exception er) 
            {
                response.State = Models.RequestState.FAILED;
                response.Message = er.Message;
            }
            return Json(response);
        }

        [Route("sendFailureOrder")]
        public JsonResult SendFailureOrder(FailureToAppearRequest request)
        {
            FailureToAppearResponse response = new FailureToAppearResponse();
            try 
            {
                _failureToAppearRepository.Create(new Models.FailureToAppear() 
                {
                     Date = request.Date,
                     EmployeeID = request.EmployeeID,
                     Reason = request.Reason
                });
                response.State = Models.RequestState.COMPLETED;
                response.Message = "Сведения о пропуске сотрудника добавлены в базу" +
                                   $"Номер сотрудника: {request.EmployeeID}";
            } 
            catch (Exception er) 
            {
                response.State = Models.RequestState.FAILED;
                response.Message = er.Message;
            }
            return Json(response);
        }

        [Route("sendBuisnessTripOrder")]
        public JsonResult SendBuisnessTripOrder(BuisnessTripOrderRequest request)
        {
            BuisnessTripOrderResponse response = new BuisnessTripOrderResponse();
            try 
            {
                _buisnessTripOrderRepository.Create(new Models.BuisnessTripOrder() 
                {
                     EmployeeID = request.EmployeeID,
                     EndDate = request.EndDate,
                     Payment = request.Payment,
                     Position = request.Position,
                     StartDate = request.StartDate
                });
                response.State = Models.RequestState.COMPLETED;
                response.Message = "Приказ об отправке в командировку добавлен в базу" +
                                   $"Номер сотрудника: {request.EmployeeID}";
            } 
            catch (Exception er) 
            {
                response.State = Models.RequestState.FAILED;
                response.Message = er.Message;
            }
            return Json(response);
        }

        [Route("sendDismissalOrder")]
        public JsonResult SendDismissalOrder(DismissalOrderRequest request)
        {

            DismissalOrderResponse response = new DismissalOrderResponse();
            try
            {
                _dismissalOrderRepository.Create(new Models.DismissalOrder() 
                {
                     EmployeeID = request.EmployeeID,
                     EndDate = request.EndDate,
                     Reason = request.Reason
                });
                response.State = Models.RequestState.COMPLETED;
                response.Message = "Приказ об увольнении сотрудника добавлен в базу" +
                                   $"Номер сотрудника: {request.EmployeeID}";
            } 
            catch (Exception er) 
            {
                response.State = Models.RequestState.FAILED;
                response.Message = er.Message;
            }
            return Json(response);
        }
    }
}
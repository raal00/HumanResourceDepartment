using System;
using DBproject.Models.SpecModels;
using DBproject.Models.SpecModels.RequestModels;
using DBproject.Models.SpecModels.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace DBproject.Controllers
{
    [Route("order")]
    public class OrderController : Controller
    {
        [Route("orderPanel")]
        public IActionResult OrderPanel()
        {
            return View();
        }

        [Route("sendSickOrder")]
        public JsonResult SendSickOrder(SickOrderRequest request) 
        {
            SickOrderResponse response = new SickOrderResponse();
            return Json(response);
        }

        [Route("sendQualificationOrder")]
        public JsonResult SendQualificationOrder(QualificationOrderRequest request)
        {
            QualificationOrderResponse response = new QualificationOrderResponse();
            return Json(response);
        }

        [Route("sendVacationOrder")]
        public JsonResult SendVacationOrder(VacationOrderRequest request)
        {
            VacationOrderResponse response = new VacationOrderResponse();
            return Json(response);
        }

        [Route("sendFailureOrder")]
        public JsonResult SendFailureOrder(FailureToAppearRequest request)
        {
            FailureToAppearResponse response = new FailureToAppearResponse();
            return Json(response);
        }

        [Route("sendBuisnessTripOrder")]
        public JsonResult SendBuisnessTripOrder(BuisnessTripOrderRequest request)
        {
            BuisnessTripOrderResponse response = new BuisnessTripOrderResponse();
            return Json(response);
        }

        [Route("sendDismissalOrder")]
        public JsonResult SendDismissalOrder(DismissalOrderRequest request)
        {
            DismissalOrderResponse response = new DismissalOrderResponse();
            return Json(response);
        }
    }
}
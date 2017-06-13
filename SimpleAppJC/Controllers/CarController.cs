using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleAppJc.Service.Interfaces;
using SimpleAppJc.Repository;
using SimpleAppJc.Domain;


namespace SimpleAppJc.Controllers
{
    public class CarController : Controller
    {
        readonly ICarService _carService;
        // GET: Car

            public CarController(ICarService carService)
        {
            this._carService = carService;
        }
        public ActionResult Index()
        {
            var data = _carService.GetAll();

            LogRepository myClass = new LogRepository();

            //Test file logging
            myClass.fileLogging();

            return View(data);
        }
        public JsonResult GetAllCars()
        {
            return Json(_carService.GetAll(), JsonRequestBehavior.AllowGet);
        }

   
        [HttpGet]
        public JsonResult saveEnquiry(string firstname,string lastname, string email,
            string make,string model,string carid) {

            LogRepository myClass = new LogRepository();
            var viewModel = new CarViewModel
            {
                carid = carid,
                firstname = firstname,
                lastname = lastname,
                email = email,
                make = make,
                model = model
            };

            myClass.saveEnquiryToFile(viewModel);


            return Json(new { Status = true }, JsonRequestBehavior.AllowGet);
        }
    }
}
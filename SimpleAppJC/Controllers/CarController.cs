using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleAppJc.Service.Interfaces;
using SimpleAppJc.Repository;

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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleAppJc.Service.Interfaces;

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

            return View(data);
        }
    }
}
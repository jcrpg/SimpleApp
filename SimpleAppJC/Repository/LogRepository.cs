using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleAppJc.Service.Interfaces;
using log4net;
using UnityLog4NetExtension.CreationStackTracker;
using SimpleAppJc.Domain;

namespace SimpleAppJc.Repository
{
    public class LogRepository : ILogService
    {
        private readonly log4net.ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LogRepository(ILog logger) {
            _logger = logger;
        }
        public LogRepository() { }

        public void fileLogging()
        {
            //_logger.fileLogging();
            _logger.Info("testing");
        }

        public void saveEnquiryToFile(CarViewModel car)
        {
            _logger.Info("Make: " + car.make +", Model:" + car.model+
                ", contact first name:" + car.firstname + 
                ",contact last name:" + car.lastname + 
                ", email:" + car.email + ",car id:" + car.carid);

        }
    }
}
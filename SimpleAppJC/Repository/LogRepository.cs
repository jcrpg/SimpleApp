using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleAppJc.Service.Interfaces;
using log4net;
using UnityLog4NetExtension.CreationStackTracker;

namespace SimpleAppJc.Repository
{
    public class LogRepository : ILogService
    {
        //private readonly ILog _logger;
        //private  readonly ILog _logger;
        private readonly log4net.ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //private readonly ILog _logger;
        public LogRepository(ILog logger) {
            _logger = logger;
        }
        public LogRepository() { }
        //public LogRepository(ILog logger)
        //{
        //    this._logger = logger;
        //}
        public void fileLogging()
        {
            //_logger.fileLogging();
            _logger.Info("testing");
        }
    }
}
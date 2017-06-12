using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAppJc.Implementations;
using SimpleAppJc.Repository;
using SimpleAppJc.Service;
using UnityLog4NetExtension.Log4Net;
using log4net;
using SimpleAppJc.Service.Interfaces;

namespace SimpleAppJC.Tests
{
    [TestClass]
    public class LogTest
    {

        [TestMethod]
        public void LogFile()
        {
            // Arrange
            IUnityContainer myContainer = new UnityContainer()
                .AddNewExtension<LogInit>()
                .AddNewExtension<Log4NetExtension>();
                

            myContainer.RegisterType<ILogService, LogRepository>();

            LogRepository myClass = new LogRepository();

            myClass.fileLogging();


        }
    }
}

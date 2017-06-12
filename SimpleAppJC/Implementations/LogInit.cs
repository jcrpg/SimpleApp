using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnityLog4NetExtension;
using Microsoft.Practices.Unity;
using log4net;
namespace SimpleAppJc.Implementations
{
    public class LogInit : UnityContainerExtension
    {

        protected override void Initialize()
        {
            Logger.Setup();
        }
    }
}
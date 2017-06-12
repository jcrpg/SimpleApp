using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net.Repository.Hierarchy;
using log4net.Layout;
using log4net.Appender;
using log4net.Core;
using log4net;

namespace SimpleAppJc.Implementations
{
    public static class Logger
    {
        private static string LogFile;
        private static string LogLevel;

        static Logger()
        {
            LogFile = "SimpleAppJc.log";
            LogLevel = "INFO";
        }
        public static void Setup()
        {
            var hierarchy = (Hierarchy)LogManager.GetRepository();
            var level = hierarchy.LevelMap[LogLevel] ?? Level.Off;

            var patternLayout = new PatternLayout { ConversionPattern = "%date [%thread] %-6level %logger – %message%exception%newline" };
            patternLayout.ActivateOptions();

            var roller = new RollingFileAppender
            {
                AppendToFile = true,
                File = LogFile,
                RollingStyle = RollingFileAppender.RollingMode.Composite,
                DatePattern = ".yyyyMMdd",
                MaxSizeRollBackups = 10,
                StaticLogFileName = true,
                LockingModel = new FileAppender.MinimalLock(),
                Layout = patternLayout,
            };
            roller.ActivateOptions();

            hierarchy.Root.AddAppender(roller);
            hierarchy.Root.Level = level;
            hierarchy.Configured = true;
        }
    }
}
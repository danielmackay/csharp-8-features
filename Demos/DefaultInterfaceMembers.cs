using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.Demos
{
    public static class DefaultInterfaceMembers
    {
        public static void Demo()
        {
            var lc = LoggerFactory.GetLogger(LoggerType.Console);
            lc.Log("Hello");

            var ld = LoggerFactory.GetLogger(LoggerType.Database);
            ld.Log("Hello");

            var le = LoggerFactory.GetLogger(LoggerType.Event);
            le.Log("Hello");
        }
    }

    interface ILogger
    {
        void Log(string msg);

        void Log(string msg, int code) => Console.WriteLine("Default implementation");
    }

    class ConsoleLogger : ILogger
    {
        void ILogger.Log(string msg) => Console.WriteLine(msg);

        // No implementation of Log(msg, code) so the default will be used
    }

    class DatabaseLogger : ILogger
    {
        void ILogger.Log(string msg) => Console.WriteLine($"'{msg}' inserted in DB");

        void Log(string msg, int code) => Console.WriteLine("Database specific implementation");
    }

    class EventLogger : ILogger
    {
        void ILogger.Log(string msg) => Console.WriteLine($"'{msg}' sent to event log");
    }

    enum LoggerType { Console, Database, Event };

    static class LoggerFactory
    {
        public static ILogger GetLogger(LoggerType type) => type switch
        {
            LoggerType.Console => new ConsoleLogger(),
            LoggerType.Database => new DatabaseLogger(),
            LoggerType.Event => new EventLogger(),
            _ => throw new Exception("Logger doesn't exist")
        };
    }
}

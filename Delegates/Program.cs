using System;

namespace Delegates
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates");
            Logger.WriteMessage += LoggingMethods.LogToConsole;
            var fileLogger = new FileLogger("log.txt");
            Logger.WriteMessage += fileLogger.LogMessage;
            Logger.LogMessage(Severity.Information, nameof(Program), "Hello World");
        }
    }
}

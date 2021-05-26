using System;

namespace Delegates
{
    public static class Logger
    {
        public static Action<string> WriteMessage;
        public static void LogMessage(Severity severity, string component, string message)
        {
            var output = $"{DateTime.Now}\t{severity}\t{component}\t{message}";
            WriteMessage?.Invoke(output);
        }
    }
}

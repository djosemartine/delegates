using System;
using System.IO;

namespace Delegates
{
    public class FileLogger
    {
        private readonly string logPath;
        public FileLogger(string path)
        {
            logPath = path;
        }

        // make sure this can't throw.
        public void LogMessage(string msg)
        {
            try
            {
                using var log = File.AppendText(logPath);
                log.WriteLine(msg);
                log.Flush();
            }
            catch (Exception)
            {
                // Hmm. We caught an exception while
                // logging. We can't really log the
                // problem (since it's the log that's failing).
                // So, while normally, catching an exception
                // and doing nothing isn't wise, it's really the
                // only reasonable option here.
            }
        }
    }
}

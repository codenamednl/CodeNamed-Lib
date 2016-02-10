using System;
using System.Diagnostics;

namespace CodeNamed.Infrastructure.Logging
{
    public class LoggingProvider : ILoggingProvider
    {
        public void Error(Exception ex, string customMessage = "")
        {
            Trace.TraceError($"{ex.Message} - Exception type: {ex.GetType()}{Environment.NewLine}Stack Trace:{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}-------{Environment.NewLine}{ex}");
        }

        public void Info(string message)
        {
            Trace.TraceInformation(message);
        }

        public void Warning(string message)
        {
            Trace.TraceWarning(message);
        }

        public void WriteToLog(params string[] lines)
        {
            foreach (var message in lines)
                Trace.WriteLine(message);
        }
    }
}
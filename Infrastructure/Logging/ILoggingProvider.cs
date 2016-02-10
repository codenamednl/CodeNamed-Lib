using System;

namespace CodeNamed.Infrastructure.Logging
{
    public interface ILoggingProvider
    {
        void Error(Exception ex, string customMessage = "");
        void Info(string message);
        void Warning(string message);
        void WriteToLog(params string[] lines);
    }
}
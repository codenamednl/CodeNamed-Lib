using System;

namespace CodeNamed.Infrastructure.Logging
{
    public interface ILoggingProvider
    {
        void Error(Exception ex, string customMessage = "");
        void Error(string message);
        void Info(string message);
        void Warning(string message);        
        void WriteToLog(string category, params string[] lines);
    }
}
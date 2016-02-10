using System;

namespace CodeNamed.Infrastructure.Logging
{
    public interface ILogginProvider
    {
        void Error(Exception ex, string customMessage = "");
        void Info(string message);
        void Warning(string message);
        void WriteToLog(params string[] lines);
    }
}
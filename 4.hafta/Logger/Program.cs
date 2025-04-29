using System;
using System.IO;

public class Logger
{
    private string _logFilePath;

    public Logger(string logFilePath)
    {
        _logFilePath = logFilePath;

        if (!File.Exists(_logFilePath))
        {
            using (File.Create(_logFilePath)) { }
        }
    }

    public void LogInfo(string message)
    {
        Log("INFO", message);
    }

    public void LogWarning(string message)
    {
        Log("WARNING", message);
    }

    public void LogError(string message)
    {
        Log("ERROR", message);
    }

    private void Log(string logLevel, string message)
    {
        string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{logLevel}] {message}";

        using (StreamWriter writer = new StreamWriter(_logFilePath, true))
        {
            writer.WriteLine(logMessage);
        }

        Console.WriteLine(logMessage);
    }
}

class Program
{
    static void Main()
    {
        Logger logger = new Logger("log.txt");

        logger.LogInfo("Program başlatıldı.");
        logger.LogWarning("Dikkat edilmesi gereken bir durum var.");
        logger.LogError("Bir hata oluştu!");

        Console.WriteLine("Log işlemi tamamlandı.");
    }
}

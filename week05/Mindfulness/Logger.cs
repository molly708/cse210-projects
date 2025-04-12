// Logger.cs

using System;
using System.IO;

public static class Logger
{
    private static readonly string logFilePath = "logs.txt";

    public static void LogActivity(string activityName, int duration, string details = "")
    {
        string logEntry = $"{DateTime.Now}: {activityName} - Duration: {duration} seconds. {details}";
        File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
    }

    public static void ViewLogs()
    {
        if (File.Exists(logFilePath))
        {
            string[] logs = File.ReadAllLines(logFilePath);
            Console.WriteLine("\n--- Activity Logs ---\n");

            if (logs.Length == 0)
            {
                Console.WriteLine("No logs found.");
            }
            else
            {
                foreach (var log in logs)
                {
                    Console.WriteLine(log);
                }
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nNo logs found.");
        }
    }
}

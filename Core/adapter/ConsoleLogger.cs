namespace DevToolkit.Core.adapter;

public class ConsoleLogger : ILoggerAdapter
{
    public void Log(string message) => Console.WriteLine($"LOG: {message}");
}

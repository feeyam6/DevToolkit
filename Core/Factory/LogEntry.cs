namespace DevToolkit.Core.Factory;

public class LogEntry : INote
{
    public string Title => "Log Entry";
    public string Content { get; }

    public LogEntry(string message)
    {
        Content = $"[{DateTime.Now}] {message}";
    }

    public void Display() => Console.WriteLine($"📝 {Content}");
}

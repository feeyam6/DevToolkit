namespace DevToolkit.Core.Observer;

public class NoteObserver : IObserver
{
    public void Notify(string message) => Console.WriteLine($"📢 {message}");
}
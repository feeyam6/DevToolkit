namespace DevToolkit.Core.Observer;

public class NoteSubject
{
    private readonly List<IObserver> _observers = new();

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void NotifyAll(string message)
    {
        foreach (var observer in _observers) observer.Notify(message);
    }
}
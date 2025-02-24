namespace DevToolkit.Core.Observer;

public interface IObserver
{
    void Notify(string message);
}
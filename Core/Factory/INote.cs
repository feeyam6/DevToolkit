namespace DevToolkit.Core.Factory;

public interface INote
{
    string Title { get; }
    string Content { get; }
    void Display();
}

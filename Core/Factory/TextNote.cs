namespace DevToolkit.Core.Factory;

public class TextNote : INote
{
    public string Title { get; }
    public string Content { get; }

    public TextNote(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public void Display() => Console.WriteLine($"📒 {Title}: {Content}");
}


namespace DevToolkit.Core.Factory;

public class NoteFactory
{
    public static INote CreateNote(string type, string title, string content)
    {
        return type.ToLower() switch
        {
            "log" => new LogEntry(content),
            _ => new TextNote(title, content)
        };
    }
}

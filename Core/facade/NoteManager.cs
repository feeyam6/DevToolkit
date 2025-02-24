using DevToolkit.Core.Factory;

namespace DevToolkit.Core.facade;

public class NotesManager
{
    private readonly List<INote> _notes = new();

    public void AddNote(INote note)
    {
        _notes.Add(note);
        Console.WriteLine($"✅ Note added: {note.Title}");
    }

    public void ShowAllNotes()
    {
        Console.WriteLine("\n📌 Your Notes:");
        foreach (var note in _notes) note.Display();
    }
}
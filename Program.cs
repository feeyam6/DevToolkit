using DevToolkit.Core.facade;
using DevToolkit.Core.Factory;
using DevToolkit.Core.Observer;

class Program
{
    static void Main()
    {
        var noteManager = new NotesManager();
        var observer = new NoteObserver();

        var note = NoteFactory.CreateNote("text", "Meeting Notes", "Discuss project roadmap.");
        noteManager.AddNote(note);

        var log = NoteFactory.CreateNote("log", "", "User created a new note.");
        noteManager.AddNote(log);

        noteManager.ShowAllNotes();
    }
}
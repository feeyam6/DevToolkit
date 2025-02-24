using DevToolkit.Core.Factory;

namespace DevToolkit.Core.Repository;

public interface IBaseRepository<T> where T: INote
{
    public void SaveNotes(List<T> notes);
    public List<T> LoadNotes();
}


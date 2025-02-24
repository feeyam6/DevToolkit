using DevToolkit.Core.Factory;
using DevToolkit.Core.Singleton;

namespace DevToolkit.Core.Repository;

public class NotesRepository : BaseRepository<INote>, INotesRepository
{
    public NotesRepository() : base(ConfigurationManager.Instance.NotesFilePath) { }
}
using DevToolkit.Core.Factory;
using DevToolkit.Core.Singleton;

namespace DevToolkit.Core.Repository;

class LogRepository : BaseRepository<INote>, INotesRepository
{
    public LogRepository() : base(ConfigurationManager.Instance.LogsFilePath) { }
}
using DevToolkit.Core.Factory;
using Newtonsoft.Json;

namespace DevToolkit.Core.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : INote
{
    private readonly string _filePath;

    public BaseRepository(string filePath)
    {
        _filePath = filePath;
    }

    public List<T> LoadNotes()
    {
        return File.Exists(_filePath)
            ? JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(_filePath))
            : new List<T>();
    }

    public void SaveNotes(List<T> notes)
    {
        File.WriteAllText(_filePath, JsonConvert.SerializeObject(notes));
    }
}


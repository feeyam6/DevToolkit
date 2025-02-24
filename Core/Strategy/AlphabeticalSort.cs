using DevToolkit.Core.Factory;

namespace DevToolkit.Core.Strategy;

public class AlphabeticalSort : ISortStrategy
{
    public List<INote> Sort(List<INote> notes) => notes.OrderBy(n => n.Title).ToList();
}

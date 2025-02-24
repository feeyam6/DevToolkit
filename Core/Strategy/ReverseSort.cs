using DevToolkit.Core.Factory;

namespace DevToolkit.Core.Strategy;

public class ReverseSort : ISortStrategy
{
    public List<INote> Sort(List<INote> notes) => notes.OrderByDescending(n => n.Title).ToList();
}

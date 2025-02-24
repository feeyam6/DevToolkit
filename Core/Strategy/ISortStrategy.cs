using DevToolkit.Core.Factory;

namespace DevToolkit.Core.Strategy;

public interface ISortStrategy
{
    List<INote> Sort(List<INote> notes);
}
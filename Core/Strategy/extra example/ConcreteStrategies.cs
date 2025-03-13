namespace DevToolkit.Core.Strategy.extra_example;

public class BubbleSortStrategy : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("🔵 Using Bubble Sort");
        // Bubble Sort logic (simplified for example)
        int temp;
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - 1 - i; j++)
            {
                if (list[j] > list[j + 1])
                {
                    temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }
}

public class QuickSortStrategy : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("🟢 Using Quick Sort");
        list.Sort(); // Using built-in sort for simplicity
    }
}

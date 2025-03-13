namespace DevToolkit.Core.Strategy.extra_example;

class StrategyProgram
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 8, 4, 2 };

        // Create context
        SortContext context = new SortContext();

        // Set Bubble Sort strategy
        context.SetSortStrategy(new BubbleSortStrategy());
        context.Sort(numbers);
        Console.WriteLine("Sorted List: " + string.Join(", ", numbers));

        Console.WriteLine();

        // Change to Quick Sort strategy
        context.SetSortStrategy(new QuickSortStrategy());
        context.Sort(numbers);
        Console.WriteLine("Sorted List: " + string.Join(", ", numbers));
    }
}

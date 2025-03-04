namespace DevToolkit.Core.proxy;

class Program
{
    static void Main()
    {
        IExpensiveService service = new ExpensiveServiceProxy();

        Console.WriteLine("\n➡ First Call:");
        service.Process(); // First call initializes the real object

        Console.WriteLine("\n➡ Second Call:");
        service.Process(); // Reuses the initialized object
    }
}

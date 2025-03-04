namespace DevToolkit.Core.proxy;

public class ExpensiveService : IExpensiveService
{
    public ExpensiveService()
    {
        Console.WriteLine("🔄 Initializing Expensive Service... (Takes time)");
        Thread.Sleep(3000); // Simulate expensive operation
        Console.WriteLine("✅ Expensive Service Ready!");
    }

    public void Process()
    {
        Console.WriteLine("🚀 Processing request in Expensive Service...");
    }
}

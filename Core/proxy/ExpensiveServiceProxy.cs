namespace DevToolkit.Core.proxy;

public class ExpensiveServiceProxy : IExpensiveService
{
    private ExpensiveService _realService;

    public void Process()
    {
        if (_realService == null)
        {
            Console.WriteLine("⏳ Creating Real Service on Demand...");
            _realService = new ExpensiveService();
        }

        _realService.Process();
    }
}

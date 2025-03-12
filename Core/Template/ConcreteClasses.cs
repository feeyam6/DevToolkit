namespace DevToolkit.Core.Template;

public class CSVDataProcessor : DataProcessor
{
    protected override void Process()
    {
        Console.WriteLine("Processing CSV data...");
    }
}

public class JSONDataProcessor : DataProcessor
{
    protected override void Process()
    {
        Console.WriteLine("Processing JSON data...");
    }
}

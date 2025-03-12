namespace DevToolkit.Core.Template;

class Program
{
    static void Main()
    {
        DataProcessor csvProcessor = new CSVDataProcessor();
        csvProcessor.ProcessData();

        Console.WriteLine();

        DataProcessor jsonProcessor = new JSONDataProcessor();
        jsonProcessor.ProcessData();
    }
}

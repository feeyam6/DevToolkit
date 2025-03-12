namespace DevToolkit.Core.Template;

public abstract class DataProcessor
{
    // Template method - defines the algorithm skeleton
    public void ProcessData()
    {
        ReadData();
        Process();
        SaveData();
    }

    // Common steps
    protected void ReadData()
    {
        Console.WriteLine("Reading data...");
    }

    protected void SaveData()
    {
        Console.WriteLine("Saving data...");
    }

    // Step to be overridden by subclasses
    protected abstract void Process();
}

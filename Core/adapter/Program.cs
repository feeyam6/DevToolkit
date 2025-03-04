namespace DevToolkit.Core.adapter;

class Program
{
    public static void main()
    {
        // Create a ConsoleLogger
        ILoggerAdapter logger = new ConsoleLogger();
        logger.Log("Hello World");
        // Create a LoggerAdapter
        ILoggerAdapter thirdPartyLogger = new LoggerAdapter();
        thirdPartyLogger.Log("Hello World");
    }
}


namespace DevToolkit.Core.adapter;

//Adapter that uses the common interface but adapts the
//adaptee (ThirdPartyLogger) to use the existing interface
public class LoggerAdapter : ILoggerAdapter
{
    private readonly ThirdPartyLogger _thirdPartyLogger =
        new ThirdPartyLogger();
    public void Log(string message) =>
        _thirdPartyLogger.WriteLog(message);
}

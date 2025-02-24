namespace DevToolkit.Core.adapter;
//Adaptee: has an incompatible interface and needs to be integrated into the new system
public class ThirdPartyLogger
{
    public void WriteLog(string msg) => Console.WriteLine($"[External Logger] {msg}");
}

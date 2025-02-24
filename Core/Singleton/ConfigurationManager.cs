namespace DevToolkit.Core.Singleton;

public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance =
         new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    public static ConfigurationManager Instance => _instance.Value;

    public string NotesFilePath { get; private set; } = "notes.json";
    public string LogsFilePath { get; private set; } = "logs.json";

    private ConfigurationManager() { }
}


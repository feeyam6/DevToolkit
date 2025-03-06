namespace DevToolkit.Core.Command;

class Program
{
    static void Main()
    {
        // Create Receiver (Light)
        Light light = new Light();

        // Create Concrete Commands
        ICommand turnOnCommand = new TurnOnLightCommand(light);
        ICommand turnOffCommand = new TurnOffLightCommand(light);

        // Create Invoker (Remote Control)
        RemoteControl remote = new RemoteControl();

        // Execute ON command
        remote.SetCommand(turnOnCommand);
        remote.PressButton(); // 💡 Light is ON

        // Execute OFF command
        remote.SetCommand(turnOffCommand);
        remote.PressButton(); // 💡 Light is OFF
    }
}

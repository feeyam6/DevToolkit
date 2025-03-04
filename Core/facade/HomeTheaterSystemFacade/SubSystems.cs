namespace DevToolkit.Core.facade.HomeTheaterSystemFacade;

public class Amplifier
{
    public void On() => Console.WriteLine("Amplifier is ON");
    public void SetVolume(int level) => Console.WriteLine($"Amplifier volume set to {level}");
    public void Off() => Console.WriteLine("Amplifier is OFF");
}

public class DVDPlayer
{
    public void On() => Console.WriteLine("DVD Player is ON");
    public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
    public void Off() => Console.WriteLine("DVD Player is OFF");
}

public class Projector
{
    public void On() => Console.WriteLine("Projector is ON");
    public void SetInput(DVDPlayer dvd) => Console.WriteLine("Projector input set to DVD Player");
    public void Off() => Console.WriteLine("Projector is OFF");
}

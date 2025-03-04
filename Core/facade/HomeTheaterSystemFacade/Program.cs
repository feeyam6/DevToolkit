namespace DevToolkit.Core.facade.HomeTheaterSystemFacade;

class Program
{
    static void Main()
    {
        // Create subsystem components
        Amplifier amp = new Amplifier();
        DVDPlayer dvd = new DVDPlayer();
        Projector projector = new Projector();

        // Create facade
        HomeTheaterSystemFacade homeTheater = new HomeTheaterSystemFacade(amp, dvd, projector);

        // Using the facade to start and stop a movie
        homeTheater.WatchMovie("Inception");
        homeTheater.EndMovie();
    }
}

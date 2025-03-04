namespace DevToolkit.Core.facade.HomeTheaterSystemFacade;

public class HomeTheaterSystemFacade
{
    private readonly Amplifier _amplifier;
    private readonly DVDPlayer _dvdPlayer;
    private readonly Projector _projector;

    public HomeTheaterSystemFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector)
    {
        _amplifier = amplifier;
        _dvdPlayer = dvdPlayer;
        _projector = projector;
    }
    public void WatchMovie(string movie)
    {
        _amplifier.On();
        _amplifier.SetVolume(10);
        _dvdPlayer.On();
        _dvdPlayer.Play(movie);
        _projector.On();
        _projector.SetInput(_dvdPlayer);
    }
    public void EndMovie()
    {
        _amplifier.Off();
        _dvdPlayer.Off();
        _projector.Off();
    }
}


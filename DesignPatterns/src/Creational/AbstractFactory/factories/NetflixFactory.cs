namespace Creational.AbstractFactory;

public class NetflixFactory : IWatchableFactory
{
    public IMovie CreateMovie()
    {
        return new NetflixMovie();
    }

    public ISerie CreateSerie()
    {
        return new NetflixSerie();
    }
}

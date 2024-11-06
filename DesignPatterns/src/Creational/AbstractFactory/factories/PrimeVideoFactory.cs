namespace Creational.AbstractFactory;

public class PrimeVideoFactory : IWatchableFactory
{
    public IMovie CreateMovie()
    {
        return new PrimeVideoMovie();
    }

    public ISerie CreateSerie()
    {
        return new PrimeVideoSerie();
    }
}

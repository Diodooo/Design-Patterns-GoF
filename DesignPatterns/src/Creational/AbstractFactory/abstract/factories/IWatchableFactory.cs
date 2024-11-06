namespace Creational.AbstractFactory;

public interface IWatchableFactory
{
    IMovie CreateMovie();
    ISerie CreateSerie();
}

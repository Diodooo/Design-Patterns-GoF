namespace Creational.AbstractFactory;

public interface AbstractWatchableFactory
{
    IMovie CreateMovie();
    ISerie CreateSerie();
}

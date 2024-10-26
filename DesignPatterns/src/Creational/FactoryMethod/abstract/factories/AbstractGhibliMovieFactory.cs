namespace Creational.FactoryMethod;

public abstract class AbstractGhibliMovieFactory
{
    public AbstractGhibliMovie SelectMovie(string movieId)
    {
        return SearchMovie(movieId);
    }

    public abstract void PrintCatalog();

    protected abstract AbstractGhibliMovie SearchMovie(string movieId);
}

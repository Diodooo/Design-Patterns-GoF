namespace Creational.FactoryMethod;

public sealed class GhibliMovieFactoryPrimeVideo : AbstractGhibliMovieFactory
{
    public override void PrintCatalog()
    {
        Console.WriteLine("0 - Howl's Moving Castle");
    }

    protected override AbstractGhibliMovie SearchMovie(string movieId)
    {
        return movieId switch
        {
            "0" => new HowlsMovingCastle(),
            _ => throw new Exception("Movie not found"),
        };
    }
}

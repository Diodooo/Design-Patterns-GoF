namespace Creational.FactoryMethod;

public sealed class GhibliMovieFactoryNetflix : AbstractGhibliMovieFactory
{
    public override void PrintCatalog()
    {
        Console.WriteLine("0 - Spirited Away");
        Console.WriteLine("1 - Kiki`s Delivery Service");
    }

    protected override AbstractGhibliMovie SearchMovie(string movieId)
    {
        return movieId switch
        {
            "0" => new SpiritedAway(),
            "1" => new KikisDeliveryService(),
            _ => throw new Exception("Invalid Movie Id"),
        };
    }
}

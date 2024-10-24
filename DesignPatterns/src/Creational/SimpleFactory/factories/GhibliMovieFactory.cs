namespace Creational.SimpleFactory;

public sealed class GhibliMovieFactory
{
    public static AbstractGhibliMovie ChooseGhibliMovie(string movieId)
    {
        return movieId switch
        {
            "0" => new SpiritedAway(),
            "1" => new KikisDeliveryService(),
            _ => throw new Exception("Invalid Movie Id"),
        };
    }
}

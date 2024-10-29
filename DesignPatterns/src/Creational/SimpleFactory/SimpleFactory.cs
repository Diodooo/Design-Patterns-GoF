namespace Creational.SimpleFactory;

public class SimpleFactory
{
    public static void Run()
    {
        Console.WriteLine("Select a movie to watch:");
        Console.WriteLine("0 - Spirited Away");
        Console.WriteLine("1 - Kiki's Delivery Service");

        var movieId = Console.ReadLine() ?? throw new Exception("Null is not a valid movieId");

        var movie = GhibliMovieFactory.ChooseGhibliMovie(movieId);
        movie.Watch();
        movie.Rate(10);
    }
}

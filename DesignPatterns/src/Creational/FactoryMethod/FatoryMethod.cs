namespace Creational.FactoryMethod;

public class FactoryMethod
{
    public static void Run()
    {
        Console.WriteLine("Select a streaming service to search for your ghibli movie:");
        Console.WriteLine("0 - Netflix");
        Console.WriteLine("1 - Prime Video");

        // Tip: The logic bellow could be transformed into a SimpleFactory
        var serviceId = Console.ReadLine() ?? throw new Exception("An error has ocurred");
        AbstractGhibliMovieFactory factory = serviceId switch
        {
            "0" => new GhibliMovieFactoryNetflix(),
            "1" => new GhibliMovieFactoryPrimeVideo(),
            _ => throw new Exception("Invalid streaming service"),
        };

        Console.WriteLine("\nChosen streaming service catalog:");
        factory.PrintCatalog();

        Console.WriteLine("\nPlease select the desired movie.");
        var movie = factory.SelectMovie(
            Console.ReadLine() ?? throw new Exception("An error has ocurred")
        );

        movie.Watch();
        movie.Rate(10);
    }
}

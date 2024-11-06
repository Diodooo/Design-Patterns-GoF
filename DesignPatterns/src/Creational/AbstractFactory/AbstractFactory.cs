using Creational.AbstractFactory;

namespace Creational.FactoryMethod;

public sealed class AbstractFactory
{
    public static void Run()
    {
        Console.WriteLine("Select a streaming service:");
        Console.WriteLine("0 - Netflix");
        Console.WriteLine("1 - Prime Video");

        var serviceId = Console.ReadLine() ?? throw new Exception("An error has ocurred");
        IWatchableFactory factory = serviceId switch
        {
            "0" => new NetflixFactory(),
            "1" => new PrimeVideoFactory(),
            _ => throw new Exception("Invalid streaming service"),
        };

        Console.WriteLine("\nDo you want to watch a movie or a serie?");
        Console.WriteLine("0 - Movie");
        Console.WriteLine("1 - Serie");
        var userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "0":
                var movie = factory.CreateMovie();
                Console.WriteLine($"Movie name: {movie.Name}");
                Console.WriteLine(
                    $"Movie duration: {movie.Duration.Hour:00}h{movie.Duration.Minute:00}min"
                );
                break;
            case "1":
                var serie = factory.CreateSerie();
                Console.WriteLine($"Serie name: {serie.Name}");
                Console.WriteLine($"Serie episodes duration: ");
                serie.EpisodeDurations.ForEach(duration =>
                    Console.WriteLine($"{duration.Hour:00}h{duration.Minute:00}min")
                );
                break;
            default:
                throw new Exception($"{userChoice} is not a valid option");
        }
    }
}

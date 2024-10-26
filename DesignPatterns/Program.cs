using Creational.FactoryMethod;

try
{
    Console.WriteLine("Select a Pattern to use:");
    Console.WriteLine("--------CREATIONAL--------");
    Console.WriteLine("0 - Simple Factory");
    Console.WriteLine("1 - Factory Method");

    var patternId = Console.ReadLine();
    switch (patternId)
    {
        case "0":
            throw new Exception("Not implemented yet");
        case "1":
            FatoryMethod.Run();
            break;
        default:
            throw new Exception("Invalid pattern");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// TODO: Move region bellow to a class method like what was done with Factory Method
# region SimpleFactory
// Console.WriteLine("Select a movie to watch:");
// Console.WriteLine("0 - Spirited Away");
// Console.WriteLine("1 - Kiki's Delivery Service");

// try
// {
//     var movieId = Console.ReadLine() ?? throw new Exception("Null is not a valid movieId");

//     var movie = GhibliMovieFactory.ChooseGhibliMovie(movieId);
//     movie.Watch();
//     movie.Rate(10);
// }
// catch (Exception e)
// {
//     Console.WriteLine($"One or more errors ocurred: {e.Message}");
// }
# endregion

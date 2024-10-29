using Creational.FactoryMethod;
using Creational.SimpleFactory;

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
            SimpleFactory.Run();
            break;
        case "1":
            FactoryMethod.Run();
            break;
        default:
            throw new Exception("Invalid pattern");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

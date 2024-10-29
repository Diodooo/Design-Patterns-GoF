namespace Creational.FactoryMethod;

public class HowlsMovingCastle : AbstractGhibliMovie
{
    public HowlsMovingCastle()
        : base("Howl's Moving Castle", new TimeOnly(2, 32), "Fantasy") { }

    public override void Rate(int rating)
    {
        Console.WriteLine($"{Name} was rated: {rating}/10");
    }

    public override void Watch()
    {
        Console.WriteLine($"Watching...");
        Console.WriteLine(
            $"You watched the film during its whole duration! Elapsed time was: {Duration.Hour:00}h{Duration.Minute:00}min"
        );
    }
}

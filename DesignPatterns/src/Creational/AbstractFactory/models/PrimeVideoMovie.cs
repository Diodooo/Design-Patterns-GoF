namespace Creational.AbstractFactory;

public class PrimeVideoMovie : IMovie
{
    public TimeOnly Duration { get; set; } = new TimeOnly(3, 22);

    public string Name { get; set; } = "Amazaon Prime Video movie!";
}

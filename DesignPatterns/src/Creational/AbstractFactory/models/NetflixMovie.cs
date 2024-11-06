namespace Creational.AbstractFactory;

public class NetflixMovie : IMovie
{
    public TimeOnly Duration { get; set; } = new TimeOnly(2, 34);

    public string Name { get; set; } = "Netflix movie!";
}

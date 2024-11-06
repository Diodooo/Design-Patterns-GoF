namespace Creational.AbstractFactory;

public class NetflixSerie : ISerie
{
    public string Name { get; set; } = "Netflix serie!";

    public List<TimeOnly> EpisodeDurations { get; set; } = [new(0, 34), new(1, 12), new(0, 24)];
}

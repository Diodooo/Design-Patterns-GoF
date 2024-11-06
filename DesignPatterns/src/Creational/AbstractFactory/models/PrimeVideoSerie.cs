namespace Creational.AbstractFactory;

public class PrimeVideoSerie : ISerie
{
    public string Name { get; set; } = "Amazon Prime Video serie!";

    public List<TimeOnly> EpisodeDurations { get; set; } = [new(0, 24), new(2, 13), new(1, 24)];
}

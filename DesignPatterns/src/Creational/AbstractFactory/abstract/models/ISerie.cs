namespace Creational.AbstractFactory;

public interface ISerie
{
    List<TimeOnly> EpisodeDurations { get; }
    string Name { get; }
}

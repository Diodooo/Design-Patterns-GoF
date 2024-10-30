namespace Creational.AbstractFactory;

public interface IMovie
{
    TimeOnly Duration { get; }
    string Name { get; }
}

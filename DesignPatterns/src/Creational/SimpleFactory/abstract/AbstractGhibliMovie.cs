namespace Creational.SimpleFactory;

public abstract class AbstractGhibliMovie
{
    protected string Name { get; set; }
    protected TimeOnly Duration { get; set; }
    protected string Genre { get; set; }

    public AbstractGhibliMovie(string name, TimeOnly duration, string genre)
    {
        Name = name;
        Duration = duration;
        Genre = genre;
    }

    public abstract void Watch();
    public abstract void Rate(int rating);
}

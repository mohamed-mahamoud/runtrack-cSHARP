namespace Tartaros.Exploration;

public class CorruptedCreature
{
    public int Health { get; set; }
    public string Name { get; set; }

    public CorruptedCreature(string name, int health)
    {
        this.Name = name;
        this.Health = health;
    }
}

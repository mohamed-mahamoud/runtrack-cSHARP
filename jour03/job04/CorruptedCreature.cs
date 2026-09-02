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

    public virtual void TakeMiasmaDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} a subi {damage} points de dégâts de miasme. Santé restante : {Health}");
    }
}

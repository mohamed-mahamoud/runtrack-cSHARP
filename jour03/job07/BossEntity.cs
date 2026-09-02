namespace tartaros.Exploration;

public abstract class BossEntity : IDamageable
{
    public string Name;
    public int Health;

    public BossEntity(string name, int health)
    {
        this.Name = name;
        this.Health = health;
    }
    public virtual void TakeDamage(int Amount)
    {
        this.Health -= Amount;
        Console.WriteLine($"Le boss a {Health} points de vie restants.");
    }
    public abstract void ExecutePhasePattern();
}

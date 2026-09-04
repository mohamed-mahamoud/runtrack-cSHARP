namespace Envou;

public class Victim
{
    public string? Name { get; private set;}
    public int Menace;
    public int Health;
    public bool Enchanted;

    public Victim(string name, int menace, int health)
    {
        this.Name = name;
        this.Menace = menace;
        this.Health = health;
        this.Enchanted = true;
    }

}

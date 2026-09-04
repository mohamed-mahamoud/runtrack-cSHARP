namespace CultistGame;

public class Cultist
{
    public string Name { get; private set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Level { get; private set; }

    public delegate double CastSpell(int level, int manaCost);

    public Cultist(string name, int health, int mana, int level)
    {
        Name = name;
        Health = health;
        Mana = mana;
        Level = level;
    }
}

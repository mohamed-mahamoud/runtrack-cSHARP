namespace Tartaros.Exploration;

public class CorruptedGargoyle : CorruptedCreature
{
   public int ArmorValue { get; set; }

    public CorruptedGargoyle(string name, int health, int armorValue) : base(name, health)
    {
        this.ArmorValue = armorValue;
    }
}

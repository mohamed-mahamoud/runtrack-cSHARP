namespace Tartaros.Exploration;

public class CorruptedGargoyle : CorruptedCreature
{
   public int ArmorValue { get; set; }

    public CorruptedGargoyle(string name, int health, int armorValue) : base(name, health)
    {
        this.ArmorValue = armorValue;
    }

    public override void TakeMiasmaDamage(int damage)
    {
        int effectiveDamage = damage - ArmorValue;
        if (effectiveDamage < 0)
        {
            effectiveDamage = 0;
        }
        base.TakeMiasmaDamage(effectiveDamage);
    }
}

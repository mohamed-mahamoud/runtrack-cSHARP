namespace Tartaros.Exploration;

public class MadAdventurer : CorruptedCreature
{
   public MadAdventurer(string name, int health) : base(name, health)
    {
    }

    public override void TakeMiasmaDamage(int damage)
    {
        base.TakeMiasmaDamage(damage);
    } 
}

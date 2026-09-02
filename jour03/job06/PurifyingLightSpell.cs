namespace tartaros.Exploration;

public class PurifyingLightSpell : AntiShadowSpell
{
    public PurifyingLightSpell(string name, int manacost) : base(name, manacost)
    {

    }

    public override void CastSpell(string target)
    {
        Console.WriteLine("purifie la lumière en infligeant des dégâts sacrés à l'ombre tout en restaurant un peu de clarté dans la pièce");
    }

}

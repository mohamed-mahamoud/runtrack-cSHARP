namespace tartaros.Exploration;

public class DisruptionWaveSpell : AntiShadowSpell
{
    public DisruptionWaveSpell(string name, int manacost) : base(name, manacost)
    {

    }

    public override void CastSpell(string target)
    {
        Console.WriteLine("Cast frappe la structure magique de l'ombre pour la faire exploser");
    }

}

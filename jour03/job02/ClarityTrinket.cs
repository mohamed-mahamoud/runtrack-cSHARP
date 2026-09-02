namespace Tartaros.Exploration;

public class ClarityTrinket: IProtectiveItem
{
    public int Protection { get; set; }
    public string Name { get; set; }

    public void Protect(int damage)
    {
        int reducedDamage = damage - Protection;
        if (reducedDamage < 0)
        {
            reducedDamage = 0;
        }
        Console.WriteLine($"Le {Name} a réduit les dégâts de {Protection}. Dégâts subis : {reducedDamage}");
    }
}

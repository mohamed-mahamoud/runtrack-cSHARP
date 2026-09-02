namespace tartaros.Exploration;

class Program
{
    static void Main(string[] args)
    {
        int currentMana = 30;
       List<AntiShadowSpell> spells = new List<AntiShadowSpell>
        {
            new PurifyingLightSpell("Lumière sacrée", 3),
            new DisruptionWaveSpell("Bénédiction divine", 45)
        };

        foreach (var spell in spells)
        {
            Console.WriteLine($"Sort : {spell.Name}, Coût en mana : {spell.Manacost}");
            if (spell.CanCast(currentMana))
            {
                spell.CastSpell("Cible ennemie");
                currentMana -= spell.Manacost;
                Console.WriteLine($"Mana restant : {currentMana}");
            }
            else
            {
                Console.WriteLine("Pas assez de mana pour lancer ce sort.");
            }
        }
    }
}

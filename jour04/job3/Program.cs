namespace CultistGame;

 class Program
{
    private static void Main()
    {
        List<Cultist> cultists = new()
        {
            new Cultist("Malachar", 100, 80, 5),
            new Cultist("Nerissa", 90, 60, 3),
            new Cultist("Varkos", 120, 100, 7)
        };

        Cultist.CastSpell castSpell = (level, manaCost) => level * manaCost;
        int manaCost = 20;
        double totalThreat = 0;

        foreach (Cultist cultist in cultists)
        {
            double spellPower = castSpell(cultist.Level, manaCost);
            totalThreat += spellPower;

            Console.WriteLine($"{cultist.Name} lance un sort d'une puissance de {spellPower}.");
            Console.WriteLine($"Menace totale : {totalThreat}");
        }
    }
}
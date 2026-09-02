namespace Tartaros.Exploration;

class Program
{
    static void Main(string[] args)
    {
        ClarityTrinket clarityTrinket = new ClarityTrinket
        {
            Name = "Amulette de clarté",
            Protection = 10
        };
        int incomingDamage = 15;
        Console.WriteLine($"\nDégâts entrants : {incomingDamage}");
        clarityTrinket.Protect(incomingDamage);
    }
}

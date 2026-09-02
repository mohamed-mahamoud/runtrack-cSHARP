namespace Tartaros.Exploration;

class Program
{
    static void Main(string[] args)
    {
        List<CorruptedCreature> creatures = new List<CorruptedCreature>
        {
            new CorruptedGargoyle("Gargouille corrompue", 100, 15),
            new MadAdventurer("Créature corrompue", 80)
        };
        foreach (var creature in creatures)
        {
            Console.WriteLine($"Créature : {creature.Name}, Santé : {creature.Health}");
            creature.TakeMiasmaDamage(20);
        }
    }
}

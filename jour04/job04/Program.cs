namespace Envou;

class Program
{
    public List<Victim> IsolateVictim (List<Victim> victims)
    {
        return victims.Where(victim => victim.Enchanted).ToList();
    }

    public Victim? MostMenacingVictims (List<Victim> victims)
    {
        return victims.OrderByDescending(victim => victim.Menace).FirstOrDefault();
    }
    public List<Victim> SortVictimsByMenace (List<Victim> victims)
    {
        return victims.OrderByDescending(victim => victim.Menace).ToList();
    }

    public static void Main()
    {
        List<Victim> victims = new()
        {
            new Victim("Alice", 50, 100),
            new Victim("Bob", 70, 80),
            new Victim("Charlie", 30, 120)
        };

        Program program = new Program();

        List<Victim> isolatedVictims = program.IsolateVictim(victims);
        Console.WriteLine("Isolated Victims:");
        foreach (Victim victim in isolatedVictims)
        {
            Console.WriteLine($"{victim.Name} - Menace: {victim.Menace}, Health: {victim.Health}");
        }

        Victim? mostMenacingVictim = program.MostMenacingVictims(victims);
        if (mostMenacingVictim != null)
        {
            Console.WriteLine($"\nMost Menacing Victim: {mostMenacingVictim.Name} - Menace: {mostMenacingVictim.Menace}, Health: {mostMenacingVictim.Health}");
        }

        List<Victim> sortedVictims = program.SortVictimsByMenace(victims);
        Console.WriteLine("\nSorted Victims by Menace:");
        foreach (Victim victim in sortedVictims)
        {
            Console.WriteLine($"{victim.Name} - Menace: {victim.Menace}, Health: {victim.Health}");
        }
    }

}

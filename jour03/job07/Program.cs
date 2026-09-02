using tartaros.Exploration;

namespace Tartaros.Exploration;

class Program
{
    static void Main(string[] args)
    {
        ReceptacleGolem golem = new ReceptacleGolem("Golem réceptacle", 20);
        while (golem.Health > 0)
        {
            Console.WriteLine($"Créature : {golem.Name}, Santé : {golem.Health}");
            golem.ExecutePhasePattern();
            golem.TakeDamage(5);
        }
        Console.WriteLine($"{golem.Name} a été vaincu !");
    }
}

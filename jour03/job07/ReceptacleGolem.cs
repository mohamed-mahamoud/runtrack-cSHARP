namespace tartaros.Exploration;

public sealed class ReceptacleGolem : BossEntity
{
    public int HealthMax;

    public ReceptacleGolem(string name, int health) : base(name, health)
    {
        this.HealthMax = health;
    }

    public override void ExecutePhasePattern()
    {
        
        

        if (Health >= HealthMax / 2)
        {
            Console.WriteLine($"{Name} attaque avec Coup de poing de pierre !");
        }
        else
        {
            Console.WriteLine($"{Name} La présence maléfique emprisonnée déborde. Il lance une attaque de zone mentale !");
        }
        
    }
}

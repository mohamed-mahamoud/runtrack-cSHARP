class Monster
{
    public string name;
    public int health;
    public bool isDangerous;

    public Monster(string name, int health, bool isDangerous)
    {
        this.name = name;
        this.health = health;
        this.isDangerous = isDangerous;
    }
}

class Job06
{

    public static void DisplayDangerousMonsters(List<Monster> monsters)
    {
        foreach (var monster in monsters)
        {
            if (monster.isDangerous)
            {
                Console.WriteLine($"Monster: {monster.name}, Health: {monster.health}");
            }
        }
    }

    public static    void TotalHealth(List<Monster> monsters)
    {
        int totalHealth = 0;
        foreach (var monster in monsters)
        {
            totalHealth += monster.health;
        }
        Console.WriteLine($"Total Health of all monsters: {totalHealth}");
    }

    public static void MostHealthyMonster(List<Monster> monsters)
    {
        Monster mostHealthy = null;
        foreach (var monster in monsters)
        {
            if (mostHealthy == null || monster.health > mostHealthy.health)
            {
                mostHealthy = monster;
            }
        }
        if (mostHealthy != null)
        {
            Console.WriteLine($"Most Healthy Monster: {mostHealthy.name}, Health: {mostHealthy.health}");
        }
    }


    static void Main(string[] args)
    {
        List<Monster> monsters = new List<Monster>();
        monsters.Add(new Monster("Goblin", 30, true));
        monsters.Add(new Monster("Troll", 50, true));
        monsters.Add(new Monster("Fairy", 20, false));

        DisplayDangerousMonsters(monsters);
        TotalHealth(monsters);
        MostHealthyMonster(monsters);
    }
}
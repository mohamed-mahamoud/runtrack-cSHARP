namespace job01;

using GuildSupply;

class Program
{
    static void Main(string[] args)
    {
        GuildSupply guildSupply = new GuildSupply();
        guildSupply.ShowSupplies();

        Console.WriteLine("\nUtilisation d'une fourniture :");
        guildSupply.UseSupply("Potion de soin");

        Console.WriteLine("\nFournitures restantes :");
        guildSupply.ShowSupplies();
    }
}

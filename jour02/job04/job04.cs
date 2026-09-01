using System.Runtime.CompilerServices;

class ReturnCard
{
    private string name;
    private int level;
    private static int totalCardsIssued = 0;

    public ReturnCard(string name, int level)
    {
        this.name = name;
        this.level = level;
        totalCardsIssued++;
    }

    public ReturnCard(ReturnCard otherCard)
    {
        this.name = otherCard.name;
        this.level = otherCard.level;
        totalCardsIssued++;
    }
    
    public static void GetPostRules()
    {
        Console.WriteLine("Donner la deuxième carte au poste");
    }
}

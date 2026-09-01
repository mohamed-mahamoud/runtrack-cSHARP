enum PotionType
{
    Health,
    Mana,
    Stamina
}

class Order
{

    public PotionType Type { get; set; }
    void affichage()
    {
        Console.WriteLine($"Type de potion: {Type}");
    }
}
namespace Tartaros.Exploration;

class Program
{
    static void Main(string[] args)
    {
        CorruptedGargoyle gargoyle = new CorruptedGargoyle("Gargouille corrompue", 100, 15);
        Console.WriteLine($"Créature : {gargoyle.Name }, Santé : {gargoyle.Health}, Valeur d'armure : {gargoyle.ArmorValue}");
    }
}

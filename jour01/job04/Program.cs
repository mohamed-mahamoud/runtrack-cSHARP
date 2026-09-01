class job04
{
    static void Main(string[] args)
    {
        Console.WriteLine("bienvenue donner vos informations");
        Console.Write("Nom: ");
        string name = Console.ReadLine();
        Console.Write("Class: ");
        string classe = Console.ReadLine();
        Console.Write("Niveau: ");
        int niveau = int.Parse(Console.ReadLine());
        Console.Write("Bienvenue " + name + " de la classe " + classe + " de niveau " + niveau);
    }
}
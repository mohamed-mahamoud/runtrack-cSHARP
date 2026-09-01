namespace job02;

public class job02
{
    private string name;
    private int age;
    private double niveau;
    private double gold;
    private bool isNew;

    // Constructeur
    public job02(string name, int age, double niveau, double gold, bool isNew)
    {
        this.name = name;
        this.age = age;
        this.niveau = niveau;
        this.gold = gold;
        this.isNew = isNew;
    }

    // Propriétés
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public double Niveau
    {
        get { return niveau; }
        set { niveau = value; }
    }

    public double Gold
    {
        get { return gold; }
        set { gold = value; }
    }

    public bool IsNew
    {
        get { return isNew; }
        set { isNew = value; }
    }

    // Méthode ToString
    public override string ToString()
    {
        return $"Nom: {name}, Âge: {age}, Niveau: {niveau}, Or: {gold}, Nouveau: {isNew}";
    }

    public void Affichage()
    {
        Console.WriteLine($"Nom: {name}, Âge: {age}, Niveau: {niveau}, Or: {gold}, Nouveau: {isNew}");
    }

}

public class Program
{
    static void Main(string[] args)
    {
        job02 player1 = new job02("Alice", 25, 10.5, 100.0, true);
        job02 player2 = new job02("Bob", 30, 15.0, 200.0, false);

        player1.Affichage();
        player2.Affichage();
    }
}

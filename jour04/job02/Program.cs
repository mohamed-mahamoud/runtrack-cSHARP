class program
{
    delegate void DelagateSecour(string message);

    public double Heal (int gravité ,int fourniture)
    {
        return gravité * fourniture;
    }

    public static void Main(string[] args)
    {
        Action<string> delagateSecour = message => Console.WriteLine(message);
        delagateSecour("Évacuez immédiatement la zone, direction le point de rassemblement !");

        Func<int,int,double> heal = (gravité,fourniture) => gravité * fourniture;
        int gravité = 5;
        int fourniture = 10;
        double resultat = heal(gravité, fourniture);
        Console.WriteLine($"Résultat du soin : {resultat}");
    }
}

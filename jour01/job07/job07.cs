class job07
{
    static void ListTarget(string[] targets)
    {
        for (int i = 0; i < targets.Length; i++)
        {
            Console.WriteLine(targets[i]);
        }
    }

    static void Main(string[] args)
    {
        string[] targets ={ "Cible 1", "Cible 2", "Cible 3", "Cible 4", "Cible 5" };
        ListTarget(targets);
    }
}

class jour08
{
        static void ListTarget(string[] targets)
    {
        for (int i = 0; i < targets.Length; i++)
        {
            Console.WriteLine(targets[i]);
        }
    }

    static string[] Mix(string[] target)
    {
        Random rand = new Random();
        for (int i = 0; i < target.Length; i++)
        {
            int randomIndex = rand.Next(target.Length);
            string temp = target[i];
            target[i] = target[randomIndex];
            target[randomIndex] = temp;
        }
        return target;
    }

    static void Main(string[] args)
    {
        string[] targets = { "Cible 1", "Cible 2", "Cible 3", "Cible 4", "Cible 5" };
        Console.WriteLine("Vous vouler mélanger combien de vois ? : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            ListTarget(targets);
            targets = Mix(targets);
            Console.WriteLine("Mélange " + (i + 1) + " :");
        }
    }

}

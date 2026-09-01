class job05
{
    static void DisplayAdventure (ref string  name,ref string classe ,ref  int age ,ref double niveau,ref float gold ,ref bool isNew)
    {
        Console.WriteLine("L'anturier" + name + ", un " + classe + " de niveau " + niveau + " et d'age " + age + " est une bourde de " + gold + " d'or");
        if (isNew)
        {
            Console.WriteLine("C'est un nouveau ");
        }
        else
        {
            Console.WriteLine("il n'est pas un nouveau");
        }
    }

    static void Main(string[] args)
    {
        string name = "Pascal";
        string classe = "Guerrier";
        int age = 30;
        double niveau = 5.5;
        float gold = 100.0f;
        bool isNew = true;

        DisplayAdventure(ref name, ref classe, ref age, ref niveau, ref gold, ref isNew);
    }
}


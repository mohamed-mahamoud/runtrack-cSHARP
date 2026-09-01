class job06
{
    static void identify( int niveau)
    {
        if (niveau ==0 )
        {
        Console.WriteLine("Sans danger");
        }

        else if (niveau >= 1 && niveau <= 4)
        {
            Console.WriteLine("Peu dangeureux");
        }

        else
        {
            Console.WriteLine("Dangereux");
        }

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Donner le niveau de dangerosité");
        int niveau = int.Parse(Console.ReadLine());
        identify(niveau);
    }
}

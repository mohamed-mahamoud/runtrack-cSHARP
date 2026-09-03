namespace Wood;

class Program
{
    public void Riposte<T>(T personnage,int agressivity) where T : class
    {
        if (personnage is Mage && agressivity >5)
        {
            Console.WriteLine("Interrompre l'incantation en priorité");
        }

        else if (personnage is Archer)
        {
            Console.WriteLine("Se mettre à couvert");
        }

        else if (personnage is Guerrier && agressivity <= 3)
        {
            Console.WriteLine("Esquiver ou ignorer");
        }

        else
        {
            Console.WriteLine("Defense standard");
        }
    }


    public static void Main(string[] args)
    {
        (Mage mage,int) enemy1 = (new Mage(6),6);
        (Archer archer,int) enemy2 = (new Archer(4),4);
        (Guerrier guerrier,int) enemy3 = (new Guerrier(2),2);
        (Guerrier guerrier2,int) enemy4 = (new Guerrier(5),5);
        (Archer archer2,int) enemy5 = (new Archer(1),1);
        (Mage mage2,int) enemy6 = (new Mage(3),3);
        (Mage mage3,int) enemy7 = (new Mage(5),5);

         List<(object,int)> Bande=new List<(object,int)>{enemy1,enemy2,enemy3,enemy4,enemy5,enemy6,enemy7};

        foreach (var enemy in Bande)
        {
            Program program = new Program();
            program.Riposte(enemy.Item1,enemy.Item2);
        }

    }

}

namespace Tartaros.Exploration;

using System;
using System.Collections.Generic;

public partial class GuildSupply
{
    public void ShowSupplies()
    {
        Console.WriteLine("Fournitures de la guilde :");
        foreach (var supply in supplies)
        {
            Console.WriteLine("- " + supply);
        }
    }

    public void UseSupply(string supply)
    {
        if (supplies.Contains(supply))
        {
            supplies.Remove(supply);
            Console.WriteLine("Vous avez utilisé : " + supply);
        }
        else
        {
            Console.WriteLine("Fourniture non disponible : " + supply);
        }
    }
}

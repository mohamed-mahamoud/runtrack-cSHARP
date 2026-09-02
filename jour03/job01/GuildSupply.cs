namespace Tartaros.Exploration;

using System;
using System.Collections.Generic;

public partial class GuildSupply
{
    private List<string> supplies;

    public GuildSupply()
    {
        supplies = new List<string>();
        supplies.Add("Potion de soin");
        supplies.Add("Potion de mana");
        supplies.Add("Épée en acier");
    }
}


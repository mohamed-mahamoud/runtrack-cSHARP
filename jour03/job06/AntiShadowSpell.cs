namespace tartaros.Exploration;

public abstract class AntiShadowSpell
{
    public string Name;
    public int Manacost;

    public AntiShadowSpell(string name, int manacost)
    {
        this.Name = name;
        this.Manacost = manacost;
    }

    public abstract void CastSpell(string target);

    public bool CanCast(int currentMana)
    {
        if (currentMana >= Manacost)
        {
            return true;
        }
        else
        {
            return false;
        }
        }
    }



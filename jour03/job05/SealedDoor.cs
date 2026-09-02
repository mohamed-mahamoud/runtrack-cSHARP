namespace tartaros.Exploration;

public class SealedDoor : DungeonDoor
{
    bool keyInserted = false;


    public sealed override void Open()
    {
        if (keyInserted)
        {
            base.Open();
        }
        else
        {
            Console.WriteLine("La porte est scellée et ne peut pas être ouverte sans la clé.");
        }
    }
}

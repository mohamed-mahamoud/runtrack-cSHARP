namespace tartaros.Exploration;

class Program
{
    static void Main (string[] args)
    {
        DungeonDoor door = new DungeonDoor();
        door.Open();

        SealedDoor sealedDoor = new SealedDoor();
        sealedDoor.Open();

        RunicSeal seal = new RunicSeal();
    }
}

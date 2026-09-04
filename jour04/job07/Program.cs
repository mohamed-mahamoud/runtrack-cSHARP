namespace Exorcism;

class Program
{
    (int physicalHealth, int corruptionLevel, bool isConscious) Sameth = (100, 50, true);

    static void Main()
    {
        Program program = new Program();
        var sameth = program.Sameth;

        while (sameth.physicalHealth > 0 && sameth.corruptionLevel > 0)
        {
            sameth = program.Exorcise(sameth);
            Console.WriteLine(
                $"État de Sameth : PV = {sameth.physicalHealth}, " +
                $"Corruption = {sameth.corruptionLevel}, " +
                $"Conscient = {sameth.isConscious}");
        }
    }

    public (int physicalHealth, int corruptionLevel, bool isConscious) Exorcise(
        (int physicalHealth, int corruptionLevel, bool isConscious) sameth)
    {
        switch (sameth)
        {
            case (<= 20, > 0, false):
                int recoveredHealth = Math.Min(100, sameth.physicalHealth + 10);
                sameth = (recoveredHealth, sameth.corruptionLevel + 5, recoveredHealth >= 20);
                break;
            case (> 20, > 0, true):
                sameth = (
                    sameth.physicalHealth - 20,
                    sameth.corruptionLevel - 15,
                    sameth.physicalHealth - 20 > 20);
                break;
        }

        return sameth;
    }
}

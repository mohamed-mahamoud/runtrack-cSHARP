namespace Ritual;

class Program
{
    static void Main()
    {
        TeleportRitual ritual = new TeleportRitual();
        ritual.ProgressChanged += Ritual_ProgressChanged;
        ritual.ProgressChanged += FluxStability_ProgressChanged;

        ritual.AlignRunes();
        ritual.PurifyMiasmaStream();
        ritual.StabilizeRift();
    }

    private static void Ritual_ProgressChanged(object? sender, RitualProgressEventArgs e)
    {
        Console.WriteLine($"Étape : {e.StepName}, Progression : {e.ProgressPercentage}%, Stabilité du flux : {e.FluxStability}%");
    }

    private static int? previousFluxStability;

    private static void FluxStability_ProgressChanged(object? sender, RitualProgressEventArgs e)
    {
        if (previousFluxStability.HasValue && e.FluxStability < previousFluxStability.Value - 20)
        {
            Console.WriteLine($"ALERTE : chute importante de la stabilité du flux ({e.FluxStability}%).");
        }
        else
        {
            Console.WriteLine($"Surveillance du flux : stabilité à {e.FluxStability}%.");
        }

        previousFluxStability = e.FluxStability;
    }
}

namespace Ritual;

public class RitualProgressEventArgs : EventArgs
{
    public string StepName { get; }
    public int ProgressPercentage { get; }
    public int FluxStability { get; }

    public RitualProgressEventArgs(string stepName, int progressPercentage, int fluxStability)
    {
        StepName = stepName;
        ProgressPercentage = progressPercentage;
        FluxStability = fluxStability;
    }
}

public class TeleportRitual
{
    public event EventHandler<RitualProgressEventArgs>? ProgressChanged;

    public int ProgressPercentage { get; private set; }
    public int FluxStability { get; private set; }

    public void AlignRunes()
    {
        UpdateProgress("AlignRunes", 33, 70);
    }

    public void PurifyMiasmaStream()
    {
        UpdateProgress("PurifyMiasmaStream", 66, 85);
    }

    public void StabilizeRift()
    {
        UpdateProgress("StabilizeRift", 100, 100);
    }

    private void UpdateProgress(string stepName, int progressPercentage, int fluxStability)
    {
        ProgressPercentage = progressPercentage;
        FluxStability = fluxStability;
        ProgressChanged?.Invoke(
            this,
            new RitualProgressEventArgs(stepName, ProgressPercentage, FluxStability));
    }
}

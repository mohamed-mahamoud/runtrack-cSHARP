class Program
{
    static void Main()
    {
        int shieldPower = 50;
        List<int> shieldPowers = [shieldPower];
        (string stance, bool isCasting)[] turns =
        [
            ("Ombre", false),
            ("Absorption", false),
            ("Miasme", true),
            ("Miasme", false),
            ("Ombre", false),
            ("Absorption", false),
            ("Miasme", true)
        ];

        foreach ((string stance, bool isCasting) turn in turns)
        {
            (string stance, int shieldPower, bool isCasting) shield =
                (turn.stance, shieldPower, turn.isCasting);
            (string response, bool adapted) = ChooseCounterattack(shield);

            shieldPower = Math.Max(0, shieldPower + (adapted ? -10 : 5));
            shieldPowers.Add(shieldPower);

            Console.WriteLine($"Posture : {shield.stance}");
            Console.WriteLine($"Riposte : {response}");
            Console.WriteLine($"Attaque adaptée : {adapted}");
            Console.WriteLine($"Puissance du bouclier : {shieldPower}");
            Console.WriteLine();
        }

        bool shieldDestroyed = shieldPowers.Any(power => power <= 0);
        Console.WriteLine(shieldDestroyed
            ? "Le bouclier de Hedge est détruit."
            : "Le bouclier de Hedge tient encore.");
    }

    static (string response, bool adapted) ChooseCounterattack(
        (string stance, int shieldPower, bool isCasting) shield)
    {
        return shield switch
        {
            ("Ombre", _, _) => ("Utiliser un sort", true),
            ("Absorption", _, _) => ("Utiliser une attaque physique", true),
            ("Miasme", _, true) => ("Attaquer avec l'Égide de Tartaros", true),
            _ => ("Attaque inadaptée", false)
        };
    }
}
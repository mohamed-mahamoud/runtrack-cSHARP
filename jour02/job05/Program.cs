
class Program
{
struct TrapLocation
{
    int x;
    int y;

    public TrapLocation(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double DistanceTo(TrapLocation other)
    {
        int deltaX = this.x - other.x;
        int deltaY = this.y - other.y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

public static void Main(string[] args)
{
    TrapLocation currentPos = new TrapLocation(3, 4);
    TrapLocation backupPos = new TrapLocation(7, 1);

    double distance = currentPos.DistanceTo(backupPos);
    Console.WriteLine($"Distance entre les deux pièges : {distance}");
}
}
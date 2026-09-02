namespace Tartaros.Exploration;

public interface IProtectiveItem
{
    protected int Protection { get; set; }
    protected string Name { get; set; }

    void Protect(int damage);
}

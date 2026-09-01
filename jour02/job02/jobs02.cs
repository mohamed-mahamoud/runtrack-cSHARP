class Wolf
{
    private string name;
    private int Health;
    private int damage;

    public Wolf(string name, int health, int damage)
    {
        this.name = name;
        this.Health = health;
        this.damage = damage;
    }

    public Wolf(string name)
    {
        this.name = name;
        this.Health = 20;
        this.damage = 5;  
    }
}
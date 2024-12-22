namespace ConsoleLeague;

public class Champion
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public List<string> Items { get; set; }

    public Champion(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
        Items = new List<string>();
    }
}
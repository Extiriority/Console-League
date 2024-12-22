namespace ConsoleLeague;

public class Item
{
    public string Name { get; set; } = "no item";
    public string Cost { get; set; }
    public string Description { get; set; }
    
    public Item(string name, string cost, string description)
    {
        Name = name;
        Cost = cost;
        Description = description;
    }

    public Item()
    {
    }
}
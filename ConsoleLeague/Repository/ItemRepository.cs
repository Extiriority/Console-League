namespace ConsoleLeague.Unit;

public class ItemRepository
{
    public List<Item> items { get; private set; } = new()
    {
        new Item("Doran's Blade", "450", "Attack Damage +8"),
        new Item("Doran's Ring", "400", "Ability Power +15"),
        new Item("Doran's Shield", "450", "Health +80")
    };
}
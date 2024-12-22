// See https://aka.ms/new-console-template for more information

using ConsoleLeague;
using ConsoleLeague.Repository;
using ConsoleLeague.Unit;

Console.WriteLine("Welcome to Console League!");
Console.WriteLine("___________________________");

var selectedChampion = SelectAChampion();
Console.WriteLine($"\nYou have selected {selectedChampion.Name}!");

Console.WriteLine("___________________________");
Console.WriteLine("Welcome to Summoner's Rift!");
Console.WriteLine("___________________________");
var itemBought = BuyItem(selectedChampion);
Console.WriteLine($"\nYou have selected {itemBought.Name}!");


Champion SelectAChampion()
{
    Console.WriteLine("\nChoose your champion, select 1-3:");
    ChampionRepository championRepository = new();

    championRepository.GetAllChampionsByName().ToList().ForEach(Console.WriteLine);

    int choice = int.Parse(Console.ReadLine() ?? "1") - 1;
    Champion selectedChampion1 = championRepository.champions[choice];
    return selectedChampion1;
}

Item BuyItem(Champion champion1)
{
    Console.WriteLine("\nWould you like to purchase an item? (yes/no)");
    string? answer = Console.ReadLine();

    if (answer == "yes")
    {
        Console.WriteLine("\nChoose your item, select 1-3:");
        ItemRepository itemRepository = new();

        foreach (var item in itemRepository.items)
        {
            Console.WriteLine(item.Name);
        }

        int choice = int.Parse(Console.ReadLine() ?? "1") - 1;
        Item itemBought = itemRepository.items[choice];
        champion1.Items.Add(itemBought.Name);
        return itemBought;
    }
    return new Item();
}

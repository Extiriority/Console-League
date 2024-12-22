namespace ConsoleLeague.Repository;

public class ChampionRepository
{
    public List<Champion> champions { get; } = new()
    {
        new Champion("Garen", 500, 60),
        new Champion("Ashe", 400, 70),
        new Champion("Lux", 350, 80)
    };
    
    public IEnumerable<string> GetAllChampionsByName()
         => champions.Select(champion => champion.Name);
}
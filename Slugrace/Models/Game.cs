namespace Slugrace.Models;

public enum EndingCondition
{
    Money,
    Races,
    Time
}

public class Game
{
    public List<Player>? Players { get; set; }
    public List<Slug>? Slugs { get; set; }
    public EndingCondition GameEndingCondition { get; set; } = EndingCondition.Money;
    public int NumberOfRacesSet { get; set; } = 0;
    public int GameTimeSet { get; set; } = 0;
    public string GameOverReason { get; set; } = string.Empty;
    public List<Player> Winners { get; set; } = [];
    public int RaceNumber { get; set; }
    public int TimeElapsed { get; set; }
}


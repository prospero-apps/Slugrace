namespace Slugrace.Models;

public class Slug
{
    public string Name { get; set; } = string.Empty;
    public double Odds { get; set; }
    public double PreviousOdds { get; set; }
    public int WinNumber { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string EyeImageUrl { get; set; } = string.Empty;
    public string BodyImageUrl { get; set; } = string.Empty;
    public double BaseOdds { get; set; }
    public bool IsRaceWinner { get; set; }
}


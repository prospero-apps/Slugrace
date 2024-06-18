namespace Slugrace.Models;

public enum AccidentType
{
    BrokenLeg,
    Overheat,
    HeartAttack,
    Grass,
    Asleep,
    Blind,
    Puddle,
    Electroshock,
    TurningBack,
    Devoured
}

public class Accident
{
    public AccidentType Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Headline { get; set; } = string.Empty;
    public string Sound { get; set; } = string.Empty;
    public uint TimePosition { get; set; }
}


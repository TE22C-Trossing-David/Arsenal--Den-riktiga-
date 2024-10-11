using System.Text.Json.Serialization;

public class Monke
{
    [JsonInclude]
    public string Name;
    [JsonInclude]
    public int Damage;
    [JsonInclude]
    public int NumberOfAttacks;
    [JsonInclude]
    public int Pierce;
    [JsonInclude]
    public int Cost;
}
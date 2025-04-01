namespace api.Models;

public class Psu
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Wattage { get; set; }
    public bool Modular { get; set; }
    public float Price { get; set; }
}
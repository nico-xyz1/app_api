namespace api.Models;

public class Motherboard
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Socket { get; set; } = string.Empty;
    public string RamType { get; set; } = string.Empty;
    public string Chipset { get; set; } = string.Empty;
    public float Price { get; set; }
}
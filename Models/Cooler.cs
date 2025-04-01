namespace api.Models;

public class Cooler
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Sockets { get; set; } = string.Empty;
    public int Tdp { get; set; }
    public float Price { get; set; }
}
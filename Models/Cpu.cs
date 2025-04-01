namespace api.Models;

public class Cpu
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Cores { get; set; }
    public int Threads { get; set; }
    public float BaseFrequency { get; set; }
    public float MaxFrequency { get; set; }
    public string Socket { get; set; } = string.Empty;
    public int Tdp { get; set; }
    public bool IntegratedGraphics { get; set; }
    public float Price { get; set; }
}
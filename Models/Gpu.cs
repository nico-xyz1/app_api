namespace api.Models;

public class Gpu
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public float Vram { get; set; }
    public float Length { get; set; }
    public int Tdp { get; set; }
    public float Price { get; set; }
}
namespace api.Models;

public class Case
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public float GpuLength { get; set; }
    public float Price { get; set; }
}
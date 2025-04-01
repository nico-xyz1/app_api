namespace api.Models;

public class Ram
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public float Capacity { get; set; }
    public int Frequency { get; set; }
    public float Price { get; set; }
}
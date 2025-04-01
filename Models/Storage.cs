namespace api.Models;

public class Storage
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Connection { get; set; } = string.Empty;
    public float Capacity { get; set; }
    public string Type { get; set; } = string.Empty;
    public float Price { get; set; }
}
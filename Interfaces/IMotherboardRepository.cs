using api.Models;

namespace api.Interfaces;

public interface IMotherboardRepository
{
    Task<List<Motherboard>> GetAllAsync();
    Task<List<Motherboard>> GetByModelAsync(string model);
    Task<List<Motherboard>> GetByBrandAsync(string brand);
}
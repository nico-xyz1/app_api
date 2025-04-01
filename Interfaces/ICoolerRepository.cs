using api.Models;

namespace api.Interfaces;

public interface ICoolerRepository
{
    Task<List<Cooler>> GetAllAsync();
    Task<List<Cooler>> GetByModelAsync(string model);
    Task<List<Cooler>> GetByBrandAsync(string brand);
}
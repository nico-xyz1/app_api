using api.Models;

namespace api.Interfaces;

public interface IGpuRepository
{
    Task<List<Gpu>> GetAllAsync();
    Task<List<Gpu>> GetByModelAsync(string model);
    Task<List<Gpu>> GetByBrandAsync(string brand);
}
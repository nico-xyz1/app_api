using api.Models;

namespace api.Interfaces;

public interface ICpuRepository
{
    Task<List<Cpu>> GetAllAsync();
    Task<List<Cpu>> GetByModelAsync(string model);
    Task<List<Cpu>> GetByBrandAsync(string brand);
}
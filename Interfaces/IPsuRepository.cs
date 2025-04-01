using api.Models;

namespace api.Interfaces;

public interface IPsuRepository
{
    Task<List<Psu>> GetAllAsync();
    Task<List<Psu>> GetByModelAsync(string model);
    Task<List<Psu>> GetByBrandAsync(string brand);
}
using api.Models;

namespace api.Interfaces;

public interface ICaseRepository
{
    Task<List<Case>> GetAllAsync();
    Task<List<Case>> GetByModelAsync(string model);
    Task<List<Case>> GetByBrandAsync(string brand);
}
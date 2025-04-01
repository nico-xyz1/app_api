using api.Models;

namespace api.Interfaces;

public interface IRamRepository
{
    Task<List<Ram>> GetAllAsync();
    Task<List<Ram>> GetByModelAsync(string model);
    Task<List<Ram>> GetByBrandAsync(string brand);
}
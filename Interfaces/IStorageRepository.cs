using api.Models;

namespace api.Interfaces;

public interface IStorageRepository
{
    Task<List<Storage>> GetAllAsync();
    Task<List<Storage>> GetByModelAsync(string model);
    Task<List<Storage>> GetByBrandAsync(string brand);
}
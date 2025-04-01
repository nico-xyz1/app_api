using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class StorageRepository : IStorageRepository
{
    private readonly ApplicationDbContext _context;
    public StorageRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<List<Storage>> GetAllAsync()
    {
        return _context.Storages.ToListAsync();
    }

    public Task<List<Storage>> GetByModelAsync(string model)
    {
        return _context.Storages.Where(c => c.Model == model).ToListAsync();
    }

    public Task<List<Storage>> GetByBrandAsync(string brand)
    {
        return _context.Storages.Where(c => c.Brand == brand).ToListAsync();
    }
}
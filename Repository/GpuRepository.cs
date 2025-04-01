using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class GpuRepository : IGpuRepository
{
    private readonly ApplicationDbContext _context;
    public GpuRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<List<Gpu>> GetAllAsync()
    {
        return _context.Gpus.ToListAsync();
    }

    public Task<List<Gpu>> GetByModelAsync(string model)
    {
        return _context.Gpus.Where(c => c.Model == model).ToListAsync();
    }

    public Task<List<Gpu>> GetByBrandAsync(string brand)
    {
        return _context.Gpus.Where(c => c.Brand == brand).ToListAsync();
    }
}
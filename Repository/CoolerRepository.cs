using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class CoolerRepository : ICoolerRepository
{
    private readonly ApplicationDbContext _context;

    public CoolerRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<List<Cooler>> GetAllAsync()
    {
        return _context.Coolers.ToListAsync();
    }

    public Task<List<Cooler>> GetByModelAsync(string model)
    {
        return _context.Coolers.Where(c => c.Model == model).ToListAsync();
    }

    public Task<List<Cooler>> GetByBrandAsync(string brand)
    {
        return _context.Coolers.Where(c => c.Brand == brand).ToListAsync();
    }
}
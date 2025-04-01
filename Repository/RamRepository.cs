using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class RamRepository : IRamRepository
{
    private readonly ApplicationDbContext _context;

    public RamRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<List<Ram>> GetAllAsync()
    {
        return _context.Rams.ToListAsync();
    }

    public Task<List<Ram>> GetByModelAsync(string model)
    {
        return _context.Rams.Where(c => c.Model == model).ToListAsync();
    }

    public Task<List<Ram>> GetByBrandAsync(string brand)
    {
        return _context.Rams.Where(c => c.Brand == brand).ToListAsync();
    }
}
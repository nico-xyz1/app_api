using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class PsuRepository : IPsuRepository
{
    private readonly ApplicationDbContext _context;
    public PsuRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<List<Psu>> GetAllAsync()
    {
        return _context.Psus.ToListAsync();
    }

    public Task<List<Psu>> GetByModelAsync(string model)
    {
        return _context.Psus.Where(c => c.Model == model).ToListAsync();
    }

    public Task<List<Psu>> GetByBrandAsync(string brand)
    {
        return _context.Psus.Where(c => c.Brand == brand).ToListAsync();
    }
}
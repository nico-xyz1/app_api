using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class MotherboardRepository : IMotherboardRepository
{
    private readonly ApplicationDbContext _context;
    public MotherboardRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<List<Motherboard>> GetAllAsync()
    {
        return _context.Motherboards.ToListAsync();
    }

    public Task<List<Motherboard>> GetByModelAsync(string model)
    {
        return _context.Motherboards.Where(c => c.Model == model).ToListAsync();
    }

    public Task<List<Motherboard>> GetByBrandAsync(string brand)
    {
        return _context.Motherboards.Where(c => c.Brand == brand).ToListAsync();
    }
}
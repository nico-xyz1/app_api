using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class CpuRepository : ICpuRepository
{
    private readonly ApplicationDbContext _context;
    public CpuRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task<List<Cpu>> GetAllAsync()
    {
        return _context.Cpus.ToListAsync();
    }
    public Task<List<Cpu>> GetByModelAsync(string model)
    {
        return _context.Cpus.Where(c => c.Model == model).ToListAsync();
    }
    public Task<List<Cpu>> GetByBrandAsync(string brand)
    {
        return _context.Cpus.Where(c => c.Brand == brand).ToListAsync();
    }
}
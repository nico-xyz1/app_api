using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class CaseRepository : ICaseRepository
{
    private readonly ApplicationDbContext _context;
    public CaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<List<Case>> GetAllAsync()
    {
        return _context.Cases.ToListAsync();
    }

    public Task<List<Case>> GetByModelAsync(string model)
    {
        return _context.Cases.Where(c => c.Model == model).ToListAsync();
    }

    public Task<List<Case>> GetByBrandAsync(string brand)
    {
        return _context.Cases.Where(c => c.Brand == brand).ToListAsync();
    }
}
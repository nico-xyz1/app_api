using api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Authorize]
[Route("api/cpu")]
[ApiController]
public class CpuController : ControllerBase
{
    private readonly ICpuRepository _cpuRepository;
    
    public CpuController(ICpuRepository cpuRepository)
    {
        _cpuRepository = cpuRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var cpus = await _cpuRepository.GetAllAsync();
        return Ok(cpus);
    }
    
    [HttpGet("by-model")]
    public async Task<IActionResult> GetByModel([FromQuery] string model)
    {
        var cpuItem = await _cpuRepository.GetByModelAsync(model);
        if (cpuItem.Count() == 0) return NotFound();
        return Ok(cpuItem);
    }
    
    [HttpGet("by-brand")]
    public async Task<IActionResult> GetByBrand([FromQuery] string brand)
    {
        var cpuItem = await _cpuRepository.GetByBrandAsync(brand);
        if (cpuItem.Count() == 0) return NotFound();
        return Ok(cpuItem);
    }
}
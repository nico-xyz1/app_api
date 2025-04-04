using api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Authorize]
[ApiController]
[Route("api/gpu")]
public class GpuController : ControllerBase
{
    private readonly IGpuRepository _gpuRepository;
    
    public GpuController(IGpuRepository gpuRepository)
    {
        _gpuRepository = gpuRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var gpus = await _gpuRepository.GetAllAsync();
        return Ok(gpus);
    }
    
    [HttpGet("by-model")]
    public async Task<IActionResult> GetByModel([FromQuery] string model)
    {
        var gpu = await _gpuRepository.GetByModelAsync(model);
        if (gpu == null) return NotFound();
        return Ok(gpu);
    }

    [HttpGet("by-brand")]
    public async Task<IActionResult> GetByBrand([FromQuery] string brand)
    {
        var gpus = await _gpuRepository.GetByBrandAsync(brand);
        if (!gpus.Any()) return NotFound();
        return Ok(gpus);
    }
}
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/ram")]
public class RamController : ControllerBase
{
    private readonly IRamRepository _ramRepository;
    
    public RamController(IRamRepository ramRepository)
    {
        _ramRepository = ramRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var rams = await _ramRepository.GetAllAsync();
        return Ok(rams);
    }
    
    [HttpGet("by-model")]
    public async Task<IActionResult> GetByModel([FromQuery] string model)
    {
        var ram = await _ramRepository.GetByModelAsync(model);
        if (ram.Count() == 0) return NotFound();
        return Ok(ram);
    }

    [HttpGet("by-brand")]
    public async Task<IActionResult> GetByBrand([FromQuery] string brand)
    {
        var rams = await _ramRepository.GetByBrandAsync(brand);
        if (!rams.Any()) return NotFound();
        return Ok(rams);
    }
}
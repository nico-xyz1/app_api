using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/mobo")]
public class MotherboardsController : ControllerBase
{
    private readonly IMotherboardRepository _motherboardRepository;
    
    public MotherboardsController(IMotherboardRepository motherboardRepository)
    {
        _motherboardRepository = motherboardRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var motherboards = await _motherboardRepository.GetAllAsync();
        return Ok(motherboards);
    }
    
    [HttpGet("by-model")]
    public async Task<IActionResult> GetByModel([FromQuery] string model)
    {
        var motherboard = await _motherboardRepository.GetByModelAsync(model);
        if (motherboard.Count() == 0) return NotFound();
        return Ok(motherboard);
    }

    [HttpGet("by-brand")]
    public async Task<IActionResult> GetByBrand([FromQuery] string brand)
    {
        var motherboards = await _motherboardRepository.GetByBrandAsync(brand);
        if (!motherboards.Any()) return NotFound();
        return Ok(motherboards);
    }
}
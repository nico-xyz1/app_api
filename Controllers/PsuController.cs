using api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Authorize]
[ApiController]
[Route("api/psu")]
public class PsusController : ControllerBase
{
    private readonly IPsuRepository _psuRepository;
    
    public PsusController(IPsuRepository psuRepository)
    {
        _psuRepository = psuRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var psus = await _psuRepository.GetAllAsync();
        return Ok(psus);
    }
    
    [HttpGet("by-model")]
    public async Task<IActionResult> GetByModel([FromQuery] string model)
    {
        var psu = await _psuRepository.GetByModelAsync(model);
        if (psu.Count() == 0) return NotFound();
        return Ok(psu);
    }

    [HttpGet("by-brand")]
    public async Task<IActionResult> GetByBrand([FromQuery] string brand)
    {
        var psus = await _psuRepository.GetByBrandAsync(brand);
        if (!psus.Any()) return NotFound();
        return Ok(psus);
    }
}
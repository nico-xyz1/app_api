using api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Authorize]
[ApiController]
[Route("api/cooler")]
public class CoolersController : ControllerBase
{
    private readonly ICoolerRepository _coolerRepository;
    
    public CoolersController(ICoolerRepository coolerRepository)
    {
        _coolerRepository = coolerRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var coolers = await _coolerRepository.GetAllAsync();
        return Ok(coolers);
    }
    
    [HttpGet("by-model")]
    public async Task<IActionResult> GetByModel([FromQuery] string model)
    {
        var cooler = await _coolerRepository.GetByModelAsync(model);
        if (cooler.Count() == 0) return NotFound();
        return Ok(cooler);
    }

    [HttpGet("by-brand")]
    public async Task<IActionResult> GetByBrand([FromQuery] string brand)
    {
        var coolers = await _coolerRepository.GetByBrandAsync(brand);
        if (!coolers.Any()) return NotFound();
        return Ok(coolers);
    }
}
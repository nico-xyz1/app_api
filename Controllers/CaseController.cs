using api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Authorize]
[ApiController]
[Route("api/case")]
public class CasesController : ControllerBase
{
    private readonly ICaseRepository _caseRepository;
    
    public CasesController(ICaseRepository caseRepository)
    {
        _caseRepository = caseRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var cases = await _caseRepository.GetAllAsync();
        return Ok(cases);
    }
    
    [HttpGet("by-model")]
    public async Task<IActionResult> GetByModel([FromQuery] string model)
    {
        var caseItem = await _caseRepository.GetByModelAsync(model);
        if (caseItem == null) return NotFound();
        return Ok(caseItem);
    }

    [HttpGet("by-brand")]
    public async Task<IActionResult> GetByBrand([FromQuery] string brand)
    {
        var cases = await _caseRepository.GetByBrandAsync(brand);
        if (!cases.Any()) return NotFound();
        return Ok(cases);
    }
}
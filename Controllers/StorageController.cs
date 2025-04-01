using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/storage")]
public class StorageController : ControllerBase
{
    private readonly IStorageRepository _storageRepository;
    
    public StorageController(IStorageRepository storageRepository)
    {
        _storageRepository = storageRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var storages = await _storageRepository.GetAllAsync();
        return Ok(storages);
    }
    
    [HttpGet("by-model")]
    public async Task<IActionResult> GetByModel([FromQuery] string model)
    {
        var storage = await _storageRepository.GetByModelAsync(model);
        if (storage == null) return NotFound();
        return Ok(storage);
    }

    [HttpGet("by-brand")]
    public async Task<IActionResult> GetByBrand([FromQuery] string brand)
    {
        var storages = await _storageRepository.GetByBrandAsync(brand);
        if (!storages.Any()) return NotFound();
        return Ok(storages);
    }
}
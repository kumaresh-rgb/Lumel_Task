using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class DataController : ControllerBase
{
    private readonly CsvLoaderService _loader;

    public DataController(CsvLoaderService loader)
    {
        _loader = loader;
    }

    [HttpPost("load")]
    public async Task<IActionResult> LoadCsv()
    {
        await _loader.LoadCsvAsync("Data/sales.csv");
        return Ok("Loaded");
    }
}

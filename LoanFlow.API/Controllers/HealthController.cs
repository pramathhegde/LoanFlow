using Microsoft.AspNetCore.Mvc;

namespace LoanFlow.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Application = "LoanFlow",
            Status = "Running",
            Version = "1.0.0",
            Timestamp = DateTime.UtcNow
        });
    }
}
using Microsoft.AspNetCore.Mvc;
using service_filters.Filters;

namespace service_filters.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [ServiceFilter(typeof(ExampleFilter))]
    public IActionResult Get()
    {
        return Content("Hello world");
    }
}

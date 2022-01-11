using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Localization.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStringLocalizer<HomeController> _localizer;

    public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
    {
        _logger = logger;
        _localizer = localizer;
    }

    [HttpGet("/home")]
    public IActionResult Home()
    {
        return Ok(_localizer["HelloString"].Value);
    }

    [HttpGet("/test")]
    public IActionResult Test()
    {
        return Ok(_localizer["HelloString"].Value);
    }
}

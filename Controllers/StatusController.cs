using Microsoft.AspNetCore.Mvc;
using System;
namespace Jetstream.Controllers;

[ApiController]
[Route("[controller]")]
public class StatusController : ControllerBase
{
   
    private readonly ILogger<StatusController> _logger;

    public StatusController(ILogger<StatusController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetStatus")]
    public object Get()
    {
        return new {now = DateTime.Now};
    }
}

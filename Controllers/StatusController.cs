using Microsoft.AspNetCore.Mvc;
using System;
using Jetstream.Data;
using Microsoft.EntityFrameworkCore;

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
        JetDbContext db = new JetDbContext();
        return new
        {
            application = "Jetstream",
            version = "0.1.0",
            now = DateTime.Now,
        };
    }
}

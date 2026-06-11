using Microsoft.AspNetCore.Mvc;
using CiCdDemo.Api.Models;

namespace CiCdDemo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DeploymentController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new DeploymentInfo
        {
            ApplicationName = "Azure DevOps CI/CD Demo",
            Environment = "Development",
            Version = "1.0.0",
            DeploymentDate = DateTime.UtcNow
        });
    }
}
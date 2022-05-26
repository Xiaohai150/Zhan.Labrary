using Microsoft.AspNetCore.Mvc;

namespace Zhan.Library.Api.Controllers;

[ApiController]
public class DescriptionController : ControllerBase
{
    [Route("/api/description"),HttpGet]
    public IActionResult GetDescription()
    {
        return Ok(new
        {
            Description = "Hello Nuxt ."
        });
    }
}
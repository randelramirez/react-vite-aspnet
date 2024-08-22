using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    public ActionResult Get()
    {
        return new JsonResult(new { message = "Hello React/Vite,a message from ASP.NET Core" });
    }
}
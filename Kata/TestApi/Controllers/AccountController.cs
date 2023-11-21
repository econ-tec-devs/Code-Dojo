using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;
[ApiController]
[Route("[controller]")]
public class AccountController: ControllerBase
{
    [HttpGet]
    public ActionResult<bool> Register()
    {
        return Ok();
    }
}
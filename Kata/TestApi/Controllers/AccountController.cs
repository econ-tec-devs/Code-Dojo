using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;
[ApiController]
[Route("[controller]")]
public class AccountController: ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<bool> Register()
    {
        return Ok(true);
    }
}
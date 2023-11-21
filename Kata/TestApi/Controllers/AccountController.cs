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
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<bool> Confirm(Account account)
    {
        if (string.IsNullOrWhiteSpace(account.Email))
        {
            return BadRequest(false);
        }
        return Ok(true);
    }
}

public class Account
{
    public string Email { get; set; }
}
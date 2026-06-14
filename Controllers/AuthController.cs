using Microsoft.AspNetCore.Mvc;


namespace BankAuthApi.DTOs;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterDTO registerDTO)
    {
        return Ok();
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDTO loginDTO)
    {
        return Ok();
    }
}

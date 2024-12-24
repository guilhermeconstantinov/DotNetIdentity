using DotNetIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DotNetIdentity.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class AuthController(SignInManager<User> _signInManager) : ControllerBase
{

    [HttpPost("logout")]
    public async Task<ActionResult> Logout()
    {
        await _signInManager.SignOutAsync();

        return Ok();
    }

    [HttpGet]
    public object Get()
    {
        return new
        {
            Name = User.Identity!.Name
        };
    }
}

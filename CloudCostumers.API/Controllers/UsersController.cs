using CloudCostumers.API.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CloudCostumers.API.Controllers;

public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }
    public async Task<IActionResult> Get()
    {
        var users = await _userService.GetAllUsers();

        if (users.Any())
        {
            return Ok(users);
        }

        return NotFound();
    }
}
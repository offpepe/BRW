using BRW.API.Entities;
using BRW.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BRW.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersControllers : ControllerBase
{
    private IUserService _userService;

    public UsersControllers(IUserService userService)
    {
        _userService = userService;
    }
    [HttpGet]
    public async Task<ActionResult<IAsyncEnumerable<User>>> GetUsers()
    {
        try
        {
            var users = await _userService.GetUsers();
            if (users != null)
            {
                return Ok(users);
            }
            else
            {
                return StatusCode(StatusCodes.Status204NoContent, "Não foi encontrado nenhum usuário");
            }
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error on search users");
        }
    }
}
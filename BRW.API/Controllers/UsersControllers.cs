using BRW.API.Entities;
using BRW.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BRW.API.Controllers;

[Route("api/user")]
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
            if (users.Any())
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

    [HttpGet("{id:int}", Name = "GetUserById")]
    public async Task<ActionResult<User>> GetUserById(int id)
    {
        try
        {
            var user = await _userService.GetUserById(id);
            return user != null ? Ok(user) : StatusCode(StatusCodes.Status204NoContent);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, $"Error on search user => {e.Message}");
        }
    }

    [HttpPost]
    public async Task<ActionResult> CreateUser(User user)
    {
        try
        {
            await _userService.RegisterUser(user);
            return CreatedAtRoute(nameof(GetUserById), new { id = user.Id }, user);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, $"Error on request => {e.Message}");
        }
        
    }
}
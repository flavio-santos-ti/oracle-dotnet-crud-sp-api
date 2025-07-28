using Microsoft.AspNetCore.Mvc;
using OracleCrud.Sp.Api.Application.Interfaces;
using OracleCrud.Sp.Api.Domain.Dtos;

namespace OracleCrud.Sp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAll()
    {
        var users = await _userService.GetAllAsync();
        return Ok(users);
    }

    [HttpPost]
    public async Task<ActionResult<string>> Insert([FromBody] CreateUserDto user)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _userService.InsertAsync(user);
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<string>> Update([FromBody] UserDto user)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _userService.UpdateAsync(user);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<string>> Delete(string id)
    {
        var result = await _userService.DeleteAsync(id);
        return Ok(result);
    }
}

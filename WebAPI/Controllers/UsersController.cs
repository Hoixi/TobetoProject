using Business.Abstracts;
using Business.Dtos.Requests.UserRequests;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;
using Entities.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Admin")]

public class UsersController : ControllerBase
{
    IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromQuery] UserBase user)
    {
        var result = await _userService.AddAsync(user);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _userService.GetAllAsync(pageRequest);
        return Ok(result);
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromQuery] UpdateUserRequest updateUserRequest)
    {
        var result = await _userService.UpdateAsync(updateUserRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
        var result = await _userService.DeleteAsync(id);
        return Ok(result);
    }
    [HttpGet("getById")]
    public async Task<IActionResult> GetById([FromQuery] int id)
    {
        var result = await _userService.GetById(id);
        return Ok(result);
    }

    [HttpGet("getByMail")]
    public IActionResult GetByMail([FromQuery] string mail)
    {
        var result =  _userService.GetByMail(mail);
        return Ok(result);
    }
}

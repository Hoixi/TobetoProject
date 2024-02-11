using Business.Abstracts;
using Business.Dtos.Requests.ClassroomRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Admin")]
public class ClassroomsController : ControllerBase
{
    IClassroomService _classroomService;

    public ClassroomsController(IClassroomService classroomService)
    {
        _classroomService = classroomService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromBody] CreateClassroomRequest createClassroomRequest)
    {
        var result = await _classroomService.AddAsync(createClassroomRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _classroomService.GetAllAsync(pageRequest);
        return Ok(result);
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateClassroomRequest updateClassroomRequest)
    {
        var result = await _classroomService.UpdateAsync(updateClassroomRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromBody] int id)
    {
        var result = await _classroomService.DeleteAsync(id);
        return Ok(result);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetById([FromQuery] int id)
    {
        var result = await _classroomService.GetById(id);
        return Ok(result);
    }
}

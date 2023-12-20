using Business.Abstracts;
using Business.Dtos.Requests.ClassroomRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClassroomsController : ControllerBase
{
    IClassroomService _classroomService;

    public ClassroomsController(IClassroomService classroomService)
    {
        _classroomService = classroomService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromQuery] CreateClassroomRequest createClassroomRequest)
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
    public async Task<IActionResult> Update([FromQuery] UpdateClassroomRequest updateClassroomRequest)
    {
        var result = await _classroomService.UpdateAsync(updateClassroomRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
        var result = await _classroomService.DeleteAsync(id);
        return Ok(result);
    }
}

using Business.Abstracts;
using Business.Dtos.Requests.ClassroomRequests;
using Entities.Concretes;
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

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateClassroomRequest createClassroomRequest)
    {
        var result = await _classroomService.Add(createClassroomRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromBody] Classroom classroom)
    {
        var result=await _classroomService.Delete(classroom);
        return Ok(result);
    }

    [HttpPost("update")]
    public async Task<IActionResult> Update([FromBody] UpdateClassroomRequest updateClassroomRequest)
    {
        var result=await _classroomService.Update(updateClassroomRequest);
        return Ok(result);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetClassroomById(int id)
    {
        var result=await _classroomService.GetClassroomById(id);
        return Ok(result);
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetAll()
    {
        var result=await _classroomService.GetAll();
        return Ok(result);
    }
}

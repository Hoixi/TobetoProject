using Business.Abstracts;
using Business.Dtos.Requests.ClassroomRequests;
using Core.DataAccess.Paging;
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
        var result = await _classroomService.AddAsync(createClassroomRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromBody] Classroom classroom)
    {
        var result=await _classroomService.DeleteAsync(classroom);
        return Ok(result);
    }

    [HttpPost("update")]
    public async Task<IActionResult> Update([FromQuery] UpdateClassroomRequest updateClassroomRequest)
    {
        var result= await _classroomService.UpdateAsync(updateClassroomRequest);
        return Ok(result);
    }


    [HttpGet("getAll")]
    public async Task<IActionResult> GetAll([FromQuery]PageRequest pageRequest)
    {
        var result=await _classroomService.GetAllAsync(pageRequest);
        return Ok(result);
    }
}

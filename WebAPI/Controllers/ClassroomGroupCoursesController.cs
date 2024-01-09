using Business.Abstracts;
using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClassroomGroupCoursesController : ControllerBase
{
    IClassroomGroupCourseService _classroomGroupCourseService;

    public ClassroomGroupCoursesController(IClassroomGroupCourseService classroomGroupCourseService)
    {
        _classroomGroupCourseService = classroomGroupCourseService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromQuery] CreateClassroomGroupCourseRequest createClassroomGroupCourseRequest)
    {
        var result = await _classroomGroupCourseService.AddAsync(createClassroomGroupCourseRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _classroomGroupCourseService.GetAllAsync(pageRequest);
        return Ok(result);
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromQuery] UpdateClassroomGroupCourseRequest updateClassroomGroupCourseRequest)
    {
        var result = await _classroomGroupCourseService.UpdateAsync(updateClassroomGroupCourseRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
        var result = await _classroomGroupCourseService.DeleteAsync(id);
        return Ok(result);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetById([FromQuery] int id)
    {
        var result = await _classroomGroupCourseService.GetById(id);
        return Ok(result);
    }
}

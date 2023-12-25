using Business.Abstracts;
using Business.Dtos.Requests.ClassroomInstructorRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseInstructorsController : ControllerBase
{

    ICourseInstructorService _courseInstructorService;

    public CourseInstructorsController(ICourseInstructorService courseInstructorService)
    {
        _courseInstructorService = courseInstructorService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromQuery] CreateCourseInstructorRequest createCourseInstructorRequest)
    {
        var result = await _courseInstructorService.AddAsync(createCourseInstructorRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _courseInstructorService.GetAllAsync(pageRequest);
        return Ok(result);
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromQuery] UpdateCourseInstructorRequest updateCourseInstructorRequest)
    {
        var result = await _courseInstructorService.UpdateAsync(updateCourseInstructorRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
        var result = await _courseInstructorService.DeleteAsync(id);
        return Ok(result);
    }
}

using Business.Abstracts;
using Business.Dtos.Requests.ClassroomInstructorRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Admin")]
public class CourseInstructorsController : ControllerBase
{

    ICourseInstructorService _courseInstructorService;

    public CourseInstructorsController(ICourseInstructorService courseInstructorService)
    {
        _courseInstructorService = courseInstructorService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromBody] CreateCourseInstructorRequest createCourseInstructorRequest)
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
    public async Task<IActionResult> Update([FromBody] UpdateCourseInstructorRequest updateCourseInstructorRequest)
    {
        var result = await _courseInstructorService.UpdateAsync(updateCourseInstructorRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromBody] int id)
    {
        var result = await _courseInstructorService.DeleteAsync(id);
        return Ok(result);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetById([FromQuery] int id)
    {
        var result = await _courseInstructorService.GetById(id);
        return Ok(result);
    }

    [HttpGet("getListByInstructorId")]
    public async Task<IActionResult> GetListByInstructorId(int instructorId, [FromQuery] PageRequest pageRequest)
    {
        var result = await _courseInstructorService.GetListByInstructorId(instructorId, pageRequest);
        return Ok(result);
    }

    [HttpGet("GetListByCourseId")]
    public async Task<IActionResult> GetListByCourseId(int courseId, [FromQuery] PageRequest pageRequest)
    {
        var result = await _courseInstructorService.GetListByCourseId(courseId, pageRequest);
        return Ok(result);
    }


}

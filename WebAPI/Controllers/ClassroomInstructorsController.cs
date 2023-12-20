using Business.Abstracts;
using Business.Dtos.Requests.ClassroomInstructorRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClassroomInstructorsController : ControllerBase
{

    IClassroomInstructorService _classroomInstructorService;

    public ClassroomInstructorsController(IClassroomInstructorService classroomInstructorService)
    {
        _classroomInstructorService = classroomInstructorService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromQuery] CreateClassroomInstructorRequest createClassroomInstructorRequest)
    {
        var result = await _classroomInstructorService.AddAsync(createClassroomInstructorRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _classroomInstructorService.GetAllAsync(pageRequest);
        return Ok(result);
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromQuery] UpdateClassroomInstructorRequest updateClassroomInstructorRequest)
    {
        var result = await _classroomInstructorService.UpdateAsync(updateClassroomInstructorRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery] int Id)
    {
        var result = await _classroomInstructorService.DeleteAsync(Id);
        return Ok(result);
    }
}

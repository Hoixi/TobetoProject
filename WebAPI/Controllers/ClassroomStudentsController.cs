using Business.Abstracts;
using Business.Dtos.Requests.ClassroomStudentRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClassroomStudentsController : ControllerBase
{
    IClassroomStudentService _classroomStudentService;

    public ClassroomStudentsController(IClassroomStudentService classroomStudentService)
    {
        _classroomStudentService = classroomStudentService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromQuery] CreateClassroomStudentRequest createClassroomStudentRequest)
    {
        var result = await _classroomStudentService.AddAsync(createClassroomStudentRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _classroomStudentService.GetAllAsync(pageRequest);
        return Ok(result);
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromQuery] UpdateClassroomStudentRequest updateClassroomStudentRequest)
    {
        var result = await _classroomStudentService.UpdateAsync(updateClassroomStudentRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
        var result = await _classroomStudentService.DeleteAsync(id);
        return Ok(result);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetById([FromQuery] int id)
    {
        var result = await _classroomStudentService.GetById(id);
        return Ok(result);
    }
}

using Business.Abstracts;
using Business.Dtos.Requests.ClassroomGroupRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClassroomGroupsController : ControllerBase
{
    IClassroomGroupService _classroomGroupService;

    public ClassroomGroupsController(IClassroomGroupService classroomGroupService)
    {
        _classroomGroupService = classroomGroupService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromQuery] CreateClassroomGroupRequest createClassroomGroupRequest)
    {
        var result = await _classroomGroupService.AddAsync(createClassroomGroupRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _classroomGroupService.GetAllAsync(pageRequest);
        return Ok(result);
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromQuery] UpdateClassroomGroupRequest updateClassroomGroupRequest)
    {
        var result = await _classroomGroupService.UpdateAsync(updateClassroomGroupRequest);
        return Ok(result);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery] int Id)
    {
        var result = await _classroomGroupService.DeleteAsync(Id);
        return Ok(result);
    }
}

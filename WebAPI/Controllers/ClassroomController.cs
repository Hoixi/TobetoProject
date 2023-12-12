using Business.Abstracts;
using Business.Dtos.Requests.ClassroomRequests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClassroomController : ControllerBase
{
    IClassroomService _classroomService;

    public ClassroomController(IClassroomService classroomService)
    {
        _classroomService = classroomService;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromBody] CreateClassroomRequest createClassroomRequest)
    {
        var result = await _classroomService.Add(createClassroomRequest);
        return Ok(result);

    }
}

using Business.Abstracts;
using Business.Dtos.Requests.ClassroomGroupCourseRequest;
using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Business.Dtos.Requests.GroupRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomGroupCoursesController : ControllerBase
    {
        IClassroomGroupCourseService _classroomGroupCourseService;
        public ClassroomGroupCoursesController(IClassroomGroupCourseService classroomGroupCourseService)
        {
            _classroomGroupCourseService = classroomGroupCourseService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody]CreateClassroomGroupCourseRequest createClassroomGroupCourseRequest)
        {
            var result = await _classroomGroupCourseService.Add(createClassroomGroupCourseRequest);
            return Ok(result);

        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id, bool permanent)
        {
            var result = await _classroomGroupCourseService.Delete(Id, permanent);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _classroomGroupCourseService.GetAll(pageRequest);
            return Ok(result);
        }

        [HttpGet("GetClassroomGroupCourseById")]
        public async Task<IActionResult> Get(int Id)
        {
            var result = await _classroomGroupCourseService.GetClassroomGroupCourseById(Id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateClassroomGroupCourseRequest updateClassroomGroupCourseRequest)
        {
            var result = await _classroomGroupCourseService.Update(updateClassroomGroupCourseRequest);
            return Ok(result);
        }

    }
}

using Business.Abstracts;
using Business.Dtos.Requests.StudentRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateStudentRequest createStudentRequest)
        {
            var result = await _studentService.Add(createStudentRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id, bool permanent)
        {
            var result = await _studentService.Delete(Id, permanent);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery]PageRequest pageRequest)
        {
            var result = await _studentService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet("GetUserById")]
        public async Task<IActionResult> Get(int Id)
        {
            var result = await _studentService.GetStudentById(Id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateStudentRequest updateStudentRequest)
        {
            var result = await _studentService.Update(updateStudentRequest);
            return Ok(result);
        }
    }
}

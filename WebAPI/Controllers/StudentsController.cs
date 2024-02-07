using Business.Abstracts;
using Business.Dtos.Requests.StudentRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

    public class StudentsController : ControllerBase
    {
        IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateStudentRequest createStudentRequest)
        {
            var result = await _studentService.AddAsync(createStudentRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _studentService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateStudentRequest updateStudentRequest)
        {
            var result = await _studentService.UpdateAsync(updateStudentRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _studentService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _studentService.GetById(id);
            return Ok(result);
        }
    }
}

using Business.Abstracts;
using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Requests.CourseRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
        {
            var result = await _courseService.AddAsync(createCourseRequest);
            return Ok(result);
        }

        
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseRequest updateCourseRequest)
        {
            var result = await _courseService.UpdateAsync(updateCourseRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _courseService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _courseService.GetById(id);
            return Ok(result);
        }
    }
}

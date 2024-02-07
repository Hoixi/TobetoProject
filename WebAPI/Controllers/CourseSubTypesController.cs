using Business.Abstracts;
using Business.Dtos.Requests.CourseSubTypeRequests;
using Business.Dtos.Requests.UserRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "RequireAdminRole")]
    public class CourseSubTypesController : ControllerBase
    {
        ICourseSubTypeService _courseSubTypeService;

        public CourseSubTypesController(ICourseSubTypeService courseSubTypeService)
        {
            _courseSubTypeService = courseSubTypeService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateCourseSubTypeRequest createCourseSubTypeRequest)
        {
            var result = await _courseSubTypeService.AddAsync(createCourseSubTypeRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseSubTypeService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateCourseSubTypeRequest updateCourseSubTypeRequest)
        {
            var result = await _courseSubTypeService.UpdateAsync(updateCourseSubTypeRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _courseSubTypeService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _courseSubTypeService.GetById(id);
            return Ok(result);
        }
    }
}

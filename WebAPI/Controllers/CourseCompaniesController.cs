using Business.Abstracts;
using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Requests.CourseCompanyRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "RequireAdminRole")]
    public class CourseCompaniesController : ControllerBase
    {
        ICourseCompanyService _courseCompanyService;

        public CourseCompaniesController(ICourseCompanyService courseCompanyService)
        {
            _courseCompanyService = courseCompanyService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateCourseCompanyRequest createCourseCompanyRequest)
        {
            var result = await _courseCompanyService.AddAsync(createCourseCompanyRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseCompanyService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateCourseCompanyRequest updateCourseCompanyRequest)
        {
            var result = await _courseCompanyService.UpdateAsync(updateCourseCompanyRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _courseCompanyService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _courseCompanyService.GetById(id);
            return Ok(result);
        }
    }
}

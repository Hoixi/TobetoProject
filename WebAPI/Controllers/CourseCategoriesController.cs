using Business.Abstracts;
using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Requests.CourseCategoryRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class CourseCategoriesController : ControllerBase
    {
        ICourseCategoryService _courseCategoryService;

        public CourseCategoriesController(ICourseCategoryService courseCategoryService)
        {
            _courseCategoryService = courseCategoryService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseCategoryRequest createCourseCategoryRequest)
        {
            var result = await _courseCategoryService.AddAsync(createCourseCategoryRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseCategoryService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseCategoryRequest updateCourseCategoryRequest)
        {
            var result = await _courseCategoryService.UpdateAsync(updateCourseCategoryRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _courseCategoryService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _courseCategoryService.GetById(id);
            return Ok(result);
        }

        [HttpGet("GetListByCourseId")]
        public async Task<IActionResult> GetListByCourseId(int courseId, [FromQuery] PageRequest pageRequest)
        {
            var result = await _courseCategoryService.GetListByCourseId(courseId, pageRequest);
            return Ok(result);
        }

        [HttpGet("GetListByCategoryId")]
        public async Task<IActionResult> GetListByCategoryId(int categoryId, [FromQuery] PageRequest pageRequest)
        {
            var result = await _courseCategoryService.GetListByCategoryId(categoryId, pageRequest);
            return Ok(result);
        }
    }
}


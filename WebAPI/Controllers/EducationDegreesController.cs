using Business.Abstracts;
using Business.Dtos.Requests.EducationDegreeRequests;
using Business.Dtos.Requests.UserRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class EducationDegreesController : ControllerBase
    {
        IEducationDegreeService _educationDegreeService;

        public EducationDegreesController(IEducationDegreeService educationDegreeService)
        {
            _educationDegreeService = educationDegreeService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateEducationDegreeRequest createEducationDegreeRequest)
        {
            var result = await _educationDegreeService.AddAsync(createEducationDegreeRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _educationDegreeService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateEducationDegreeRequest updateEducationDegreeRequest)
        {
            var result = await _educationDegreeService.UpdateAsync(updateEducationDegreeRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _educationDegreeService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _educationDegreeService.GetById(id);
            return Ok(result);
        }

    }
}

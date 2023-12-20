using Business.Abstracts;
using Business.Dtos.Requests.EducationDegreeRequests;
using Business.Dtos.Requests.UserRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationDegreesController : ControllerBase
    {
        IEducationDegreeService _educationDegreeService;

        public EducationDegreesController(IEducationDegreeService educationDegreeService)
        {
            _educationDegreeService = educationDegreeService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateEducationDegreeRequest createEducationDegreeRequest)
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
        public async Task<IActionResult> Update([FromQuery] UpdateEducationDegreeRequest updateEducationDegreeRequest)
        {
            var result = await _educationDegreeService.UpdateAsync(updateEducationDegreeRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _educationDegreeService.DeleteAsync(id);
            return Ok(result);
        }
    }
}

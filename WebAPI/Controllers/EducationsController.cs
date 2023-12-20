using Business.Abstracts;
using Business.Dtos.Requests.EducationRequests;
using Business.Dtos.Requests.UserRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        IEducationService _educationService;

        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateEducationRequest createEducationRequest)
        {
            var result = await _educationService.AddAsync(createEducationRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _educationService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateEducationRequest updateEducationRequest)
        {
            var result = await _educationService.UpdateAsync(updateEducationRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _educationService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
